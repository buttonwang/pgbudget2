using System;

namespace pgbudget
{
    partial class pgproperty
    {
    }

    public interface IDictIndex
    {
        string IndexValue { get; }

        string NodeValue { get; }
    }

    public partial class project
    {
    }

    public partial class PGDataClassesDataContext
    {
    }

    public partial class deb
    {
         System.Nullable<double>  basef
        {
            get { return this.dergf + this.dejxf + this.declf; }
        }
    }

    public partial class desyb : IDictIndex
    {
        string IDictIndex.IndexValue
        {
            get { return this.syID; }
        }

        string IDictIndex.NodeValue
        {
            get { return this.NodeId ;}   
        }
    }

    public partial class cjsyb : IDictIndex
    {
        string IDictIndex.IndexValue
        {
            get { return this.syID; }
        }

        string IDictIndex.NodeValue
        {
            get { return this.NodeId; }
        }
    }

    public partial class sbsyb : IDictIndex
    {
        string IDictIndex.IndexValue
        {
            get { return this.ID.ToString(); }
        }

        string IDictIndex.NodeValue
        {
            get { return this.LAYER; }
        }
    }

    public partial class zcsyb : IDictIndex
    {
        string IDictIndex.IndexValue
        {
            get { return this.ID.ToString(); }
        }

        string IDictIndex.NodeValue
        {
            get { return this.LAYER; }
        }
    }

}