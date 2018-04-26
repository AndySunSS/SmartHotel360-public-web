using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHotel360.PublicWeb.Controllers
{
    public class GoGreenRequest
    {
        public GoGreenRequest(GoGreen goGreen, string clientnm, int roomNum, 
            DateTime checkIn, DateTime lastCleaning, string clientMessage)
        {
            ClientName = clientnm;
            RoomNumber = roomNum;
            CheckIn = checkIn;
            GoGreenReqTime = DateTime.Today;
            Message = clientMessage;
            LastCleaning = lastCleaning;
            Gg = goGreen;
        }
        public GoGreenRequest(GoGreen goGreen, string clientnm, int roomNum, DateTime checkIn, string clientMessage)
        {
            ClientName = clientnm;
            RoomNumber = roomNum;
            CheckIn = checkIn;
            GoGreenReqTime = DateTime.Today;
            Message = clientMessage;
            Gg = goGreen;
        }

        // If the client has gone without housekeeping for less than 7 days then housekeeping can be skipped.
        public bool Under7Days()
        {
            //If they checked in less than 7 days ago grant request
            if (CheckIn.AddDays(7) > GoGreenReqTime)
            {
                return true;
            }
            //If last cleaning was over 7 days ago
            else if (LastCleaning < GoGreenReqTime.AddDays(-7))
            {
                return false;
            }
            return false;
        }

        public string TextHouseKeeping(string message)
        {
            //CheckDoNotDisturb(message);
            string text = $"Guest {ClientName} in room {RoomNumber} would like to go green!";
            string unicodeText = text + "They included a message:" + message.Normalize();
            return unicodeText;
            
        }

        public void CheckDoNotDisturb(string message)
        {
            List<string> doNotDisturbMessages = new List<string>
            {
                "do not disturb",
                "donot disturb",
                "do notdisturb",
                "donotdisturb",
                "do not distrub",
                "donot disturb",
                "not to be disturbed"
            }; 

            message = message.ToLower();

            doNotDisturbMessages.ToList().ForEach(i => {
                if (message.Contains(i))
                {
                    FlagHouseKeeping(RoomNumber);
                }
                });

            foreach (string s in doNotDisturbMessages)
            {
                if (message.Contains(s))
                {
                    FlagHouseKeeping(RoomNumber);
                }
            }
        }

        private void FlagHouseKeeping(int roomNum) => Gg.DoNotDisturbRooms.Add(roomNum);

        public void UpdateLastCleaning()
        {
            TextHouseKeeping(Message);
        }
        public Guid Id { get; set; }

        public string ClientName { get; set; }

        public int RoomNumber { get; set; }

        public DateTime GoGreenReqTime { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime LastCleaning { get; set; }

        public string Message { get; set; }

        public GoGreen Gg { get; set; }
    }

    public class GoGreen
    {
        public GoGreen()
        {
            DoNotDisturbRooms = new List<int>
                { 112, 103, 205 };
            DoNotDisturbRooms.Add(122);
            Requests = new List<GoGreenRequest> { };
        }

        public List<int> DoNotDisturbRooms;

        public List<GoGreenRequest> Requests;
    }
}
