using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using System.Runtime.Serialization;

namespace Workflow.DTO.Models
{
    
    public class ObjectData
    {
        public ObjectData()
        {
        }

        public ObjectData(object value)
        {
            Set(value);
        }

        
        public SByte? SByteData { get; set; }

        
        public Int16? Int16Data { get; set; }

        
        public Int32? Int32Data { get; set; }

        
        public Int64? Int64Data { get; set; }

        
        public Byte? ByteData { get; set; }

        
        public UInt16? UInt16Data { get; set; }

        
        public UInt32? UInt32Data { get; set; }

        
        public UInt64? UInt64Data { get; set; }

        
        public Single? SingleData { get; set; }

        
        public Double? DoubleData { get; set; }

        
        public Decimal? DecimalData { get; set; }

        
        public String StringData { get; set; }

        
        public Char? CharData { get; set; }

        
        public Boolean? BooleanData { get; set; }

        
        public DateTime? DateTimeData { get; set; }

        
        public Guid? GuidData { get; set; }

        public object Get()
        {
            if (SByteData.HasValue)
            {
                return SByteData.Value;
            }
            else if (Int16Data.HasValue)
            {
                return Int16Data.Value;
            }
            else if (Int32Data.HasValue)
            {
                return Int32Data.Value;
            }
            else if (Int64Data.HasValue)
            {
                return Int64Data.Value;
            }
            else if (ByteData.HasValue)
            {
                return ByteData.Value;
            }
            else if (UInt16Data.HasValue)
            {
                return UInt16Data.Value;
            }
            else if (UInt32Data.HasValue)
            {
                return UInt32Data.Value;
            }
            else if (UInt64Data.HasValue)
            {
                return UInt64Data.Value;
            }
            else if (SingleData.HasValue)
            {
                return SingleData.Value;
            }
            else if (DoubleData.HasValue)
            {
                return DoubleData.Value;
            }
            else if (DecimalData.HasValue)
            {
                return DecimalData.Value;
            }
            else if (StringData != null)
            {
                return StringData;
            }
            else if (CharData.HasValue)
            {
                return CharData.Value;
            }
            else if (BooleanData.HasValue)
            {
                return BooleanData.Value;
            }
            else if (DateTimeData.HasValue)
            {
                return DateTimeData.Value;
            }
            else if (GuidData.HasValue)
            {
                return GuidData.Value;
            }
            return null;
        }

        public void Set(object value)
        {
            SByteData = null;
            Int16Data = null;
            Int32Data = null;
            Int64Data = null;
            ByteData = null;
            UInt16Data = null;
            UInt32Data = null;
            UInt64Data = null;
            SingleData = null;
            DoubleData = null;
            DecimalData = null;
            StringData = null; 
            CharData = null; 
            BooleanData = null; 
            DateTimeData = null; 
            GuidData = null;

            if (value != null)
            {
                if (value is SByte)
                {
                    SByteData = Convert.ToSByte(value);
                }
                else if (value is Int16)
                {
                    Int16Data = Convert.ToInt16(value);
                }
                else if (value is Int32)
                {
                    Int32Data = Convert.ToInt32(value);
                }
                else if (value is Int64)
                {
                    Int64Data = Convert.ToInt64(value);
                }
                else if (value is Byte)
                {
                    ByteData = Convert.ToByte(value);
                }
                else if (value is UInt16)
                {
                    UInt16Data = Convert.ToUInt16(value);
                }
                else if (value is UInt32)
                {
                    UInt32Data = Convert.ToUInt32(value);
                }
                else if (value is UInt64)
                {
                    UInt64Data = Convert.ToUInt64(value);
                }
                else if (value is Single)
                {
                    SingleData = Convert.ToSingle(value);
                }
                else if (value is Double)
                {
                    DoubleData = Convert.ToDouble(value);
                }
                else if (value is Decimal)
                {
                    DecimalData = Convert.ToDecimal(value);
                }
                else if (value is String)
                {
                    StringData = (String)value;
                }
                else if (value is Char)
                {
                    CharData = Convert.ToChar(value);
                }
                else if (value is Boolean)
                {
                    BooleanData = Convert.ToBoolean(value);
                }
                else if (value is DateTime)
                {
                    DateTimeData = Convert.ToDateTime(value);
                }
                else if (value is Guid)
                {
                    GuidData = (Guid)value;
                }
            }
        }
    }
}
