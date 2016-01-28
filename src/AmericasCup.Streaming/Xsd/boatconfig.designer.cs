// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>s</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AmericasCup.Streaming.Xsd
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Vtx
    {

        private int seqField;

        private bool seqFieldSpecified;

        private float yField;

        private bool yFieldSpecified;

        private float xField;

        private bool xFieldSpecified;

        [XmlAttribute()]
        public int Seq
        {
            get
            {
                return this.seqField;
            }
            set
            {
                this.seqField = value;
            }
        }

        [XmlIgnore()]
        public bool SeqSpecified
        {
            get
            {
                return this.seqFieldSpecified;
            }
            set
            {
                this.seqFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        [XmlIgnore()]
        public bool YSpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlIgnore()]
        public bool XSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class BoatConfig
    {

        private List<object> itemsField;

        public BoatConfig()
        {
            this.itemsField = new List<object>();
        }

        [XmlElement("BoatShapes", typeof(BoatConfigBoatShapes), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [XmlElement("Boats", typeof(BoatConfigBoats), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [XmlElement("Vtx", typeof(Vtx), Order = 0)]
        public List<object> Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BoatConfigBoatShapes
    {

        private List<BoatConfigBoatShapesBoatShape> boatShapeField;

        public BoatConfigBoatShapes()
        {
            this.boatShapeField = new List<BoatConfigBoatShapesBoatShape>();
        }

        [XmlElement("BoatShape", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public List<BoatConfigBoatShapesBoatShape> BoatShape
        {
            get
            {
                return this.boatShapeField;
            }
            set
            {
                this.boatShapeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BoatConfigBoatShapesBoatShape
    {

        private List<Vtx> verticesField;

        private List<Vtx> catamaranField;

        private List<Vtx> bowspritField;

        private List<Vtx> trampolineField;

        private int shapeIDField;

        private bool shapeIDFieldSpecified;

        public BoatConfigBoatShapesBoatShape()
        {
            this.trampolineField = new List<Vtx>();
            this.bowspritField = new List<Vtx>();
            this.catamaranField = new List<Vtx>();
            this.verticesField = new List<Vtx>();
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [XmlArrayItem("Vtx", typeof(Vtx), IsNullable = false)]
        public List<Vtx> Vertices
        {
            get
            {
                return this.verticesField;
            }
            set
            {
                this.verticesField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [XmlArrayItem("Vtx", typeof(Vtx), IsNullable = false)]
        public List<Vtx> Catamaran
        {
            get
            {
                return this.catamaranField;
            }
            set
            {
                this.catamaranField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        [XmlArrayItem("Vtx", typeof(Vtx), IsNullable = false)]
        public List<Vtx> Bowsprit
        {
            get
            {
                return this.bowspritField;
            }
            set
            {
                this.bowspritField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        [XmlArrayItem("Vtx", typeof(Vtx), IsNullable = false)]
        public List<Vtx> Trampoline
        {
            get
            {
                return this.trampolineField;
            }
            set
            {
                this.trampolineField = value;
            }
        }

        [XmlAttribute()]
        public int ShapeID
        {
            get
            {
                return this.shapeIDField;
            }
            set
            {
                this.shapeIDField = value;
            }
        }

        [XmlIgnore()]
        public bool ShapeIDSpecified
        {
            get
            {
                return this.shapeIDFieldSpecified;
            }
            set
            {
                this.shapeIDFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BoatConfigBoats
    {

        private List<BoatConfigBoatsBoat> boatField;

        public BoatConfigBoats()
        {
            this.boatField = new List<BoatConfigBoatsBoat>();
        }

        [XmlElement("Boat", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public List<BoatConfigBoatsBoat> Boat
        {
            get
            {
                return this.boatField;
            }
            set
            {
                this.boatField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BoatConfigBoatsBoat
    {

        private BoatConfigBoatsBoatGPSposition gPSpositionField;

        private BoatConfigBoatsBoatMastTop mastTopField;

        private BoatConfigBoatsBoatFlagPosition flagPositionField;

        private BoatConfigBoatsBoatType typeField;

        private int sourceIDField;

        private string shapeIDField;

        private string stoweNameField;

        private string shortNameField;

        private string boatNameField;

        private string hullNumField;

        private string skipperField;

        private string shorterNameField;

        private string countryField;

        public BoatConfigBoatsBoat()
        {
            this.flagPositionField = new BoatConfigBoatsBoatFlagPosition();
            this.mastTopField = new BoatConfigBoatsBoatMastTop();
            this.gPSpositionField = new BoatConfigBoatsBoatGPSposition();
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public BoatConfigBoatsBoatGPSposition GPSposition
        {
            get
            {
                return this.gPSpositionField;
            }
            set
            {
                this.gPSpositionField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public BoatConfigBoatsBoatMastTop MastTop
        {
            get
            {
                return this.mastTopField;
            }
            set
            {
                this.mastTopField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public BoatConfigBoatsBoatFlagPosition FlagPosition
        {
            get
            {
                return this.flagPositionField;
            }
            set
            {
                this.flagPositionField = value;
            }
        }

        [XmlAttribute()]
        public BoatConfigBoatsBoatType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        [XmlAttribute()]
        public int SourceID
        {
            get
            {
                return this.sourceIDField;
            }
            set
            {
                this.sourceIDField = value;
            }
        }

        [XmlAttribute()]
        public string ShapeID
        {
            get
            {
                return this.shapeIDField;
            }
            set
            {
                this.shapeIDField = value;
            }
        }

        [XmlAttribute()]
        public string StoweName
        {
            get
            {
                return this.stoweNameField;
            }
            set
            {
                this.stoweNameField = value;
            }
        }

        [XmlAttribute()]
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        [XmlAttribute()]
        public string BoatName
        {
            get
            {
                return this.boatNameField;
            }
            set
            {
                this.boatNameField = value;
            }
        }

        [XmlAttribute()]
        public string HullNum
        {
            get
            {
                return this.hullNumField;
            }
            set
            {
                this.hullNumField = value;
            }
        }

        [XmlAttribute()]
        public string Skipper
        {
            get
            {
                return this.skipperField;
            }
            set
            {
                this.skipperField = value;
            }
        }

        [XmlAttribute()]
        public string ShorterName
        {
            get
            {
                return this.shorterNameField;
            }
            set
            {
                this.shorterNameField = value;
            }
        }

        [XmlAttribute()]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BoatConfigBoatsBoatGPSposition
    {

        private float zField;

        private bool zFieldSpecified;

        private float yField;

        private bool yFieldSpecified;

        private float xField;

        private bool xFieldSpecified;

        [XmlAttribute()]
        public float Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }

        [XmlIgnore()]
        public bool ZSpecified
        {
            get
            {
                return this.zFieldSpecified;
            }
            set
            {
                this.zFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        [XmlIgnore()]
        public bool YSpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlIgnore()]
        public bool XSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BoatConfigBoatsBoatMastTop
    {

        private float zField;

        private bool zFieldSpecified;

        private float yField;

        private bool yFieldSpecified;

        private float xField;

        private bool xFieldSpecified;

        [XmlAttribute()]
        public float Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }

        [XmlIgnore()]
        public bool ZSpecified
        {
            get
            {
                return this.zFieldSpecified;
            }
            set
            {
                this.zFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        [XmlIgnore()]
        public bool YSpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlIgnore()]
        public bool XSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class BoatConfigBoatsBoatFlagPosition
    {

        private float zField;

        private bool zFieldSpecified;

        private float yField;

        private bool yFieldSpecified;

        private float xField;

        private bool xFieldSpecified;

        [XmlAttribute()]
        public float Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }

        [XmlIgnore()]
        public bool ZSpecified
        {
            get
            {
                return this.zFieldSpecified;
            }
            set
            {
                this.zFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        [XmlIgnore()]
        public bool YSpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        [XmlIgnore()]
        public bool XSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [XmlType(AnonymousType = true)]
    public enum BoatConfigBoatsBoatType
    {

        /// <remarks/>
        Yacht,

        /// <remarks/>
        RC,

        /// <remarks/>
        Mark,

        /// <remarks/>
        Umpire,

        /// <remarks/>
        Marshall,

        /// <remarks/>
        Pin,

        /// <remarks/>
        Helicopter,

        /// <remarks/>
        ClientData,

        /// <remarks/>
        UmpApp,

        /// <remarks/>
        ProApp,

        /// <remarks/>
        MDSS,
    }
}