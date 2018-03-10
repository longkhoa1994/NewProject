using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NotInsert : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NotUpdate : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NotNull : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NotZero : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class AutoAddingUser : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class AutoAddingDate : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NotConvert : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class Extract : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ExtractPercent : Attribute
    {
    }

}