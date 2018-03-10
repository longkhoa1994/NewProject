using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.Tamara
{
    public class F_TamaraTrailer : BaseModel
    {
        public long ID { get; set; }
        public long F_TamaraFileID { get; set; }
        public string RecordType { get; set; }
        public string FileType { get; set; }
        public int RecordCount { get; set; }

        public F_TamaraTrailer()
        {
            RecordType = "T";
            FileType = "E";
            RecordCount = 3;
        }

        public F_TamaraTrailer(F_TamaraFileType type)
        {
            RecordType = "T";
            if (type == F_TamaraFileType.MA)
                FileType = "M";
            else
                FileType = "E";
            RecordCount = 0;
        }

        public override string Table { get { return "F_TamaraTrailer"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TamaraTrailer_InsertOrUpdate"; } }
    }
    public enum F_TamaraTrailerColumns
    {
        ID,
        F_TamaraFileID,
        RecordType,
        FileType,
        RecordCount,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TamaraTrailerProcedure
    {

    }
    public class F_TamaraTrailerList : List<F_TamaraTrailer>
    {

    }
}