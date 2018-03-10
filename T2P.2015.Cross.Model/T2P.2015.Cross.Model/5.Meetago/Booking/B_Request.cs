using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class B_Request : BaseModel
    {
        public long ID { get; set; }
        public long B_ContractID { get; set; }
        public string Type { get; set; }
        public int Pax { get; set; }
        public int ConferenceRooms { get; set; }
        public int GuestRoomsSingle { get; set; }
        public int GuestRoomsDouble { get; set; }
        public int Apartments { get; set; }
        public int RoomNights { get; set; }

        public override string Table { get { return "B_Request"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_Request_InsertOrUpdate"; } }
    }

    public enum B_RequestProcedure
    {
        p_B_Request_Get_By_B_ContractID
    }
}
