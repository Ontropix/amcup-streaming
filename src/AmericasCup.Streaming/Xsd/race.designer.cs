// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>StreamParser</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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
    public partial class Race
    {

        private string creationTimeDateField;

        private int raceIDField;

        private RaceRaceType raceTypeField;

        private List<RaceZoneLimit> exclusionsField;

        private RaceRaceStartTime raceStartTimeField;

        private List<RaceParticipantsYacht> participantsField;

        private List<RaceCourseCompoundMark> courseField;

        private List<RaceCompoundMarkSequenceCorner> compoundMarkSequenceField;

        private List<RaceCourseLimitLimit> courseLimitField;

        public Race()
        {
            this.courseLimitField = new List<RaceCourseLimitLimit>();
            this.compoundMarkSequenceField = new List<RaceCompoundMarkSequenceCorner>();
            this.courseField = new List<RaceCourseCompoundMark>();
            this.participantsField = new List<RaceParticipantsYacht>();
            this.raceStartTimeField = new RaceRaceStartTime();
            this.exclusionsField = new List<RaceZoneLimit>();
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string CreationTimeDate
        {
            get
            {
                return this.creationTimeDateField;
            }
            set
            {
                this.creationTimeDateField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public int RaceID
        {
            get
            {
                return this.raceIDField;
            }
            set
            {
                this.raceIDField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public RaceRaceType RaceType
        {
            get
            {
                return this.raceTypeField;
            }
            set
            {
                this.raceTypeField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        [XmlArrayItem("Zone", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        [XmlArrayItem("Limit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false, NestingLevel = 1)]
        public List<RaceZoneLimit> Exclusions
        {
            get
            {
                return this.exclusionsField;
            }
            set
            {
                this.exclusionsField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public RaceRaceStartTime RaceStartTime
        {
            get
            {
                return this.raceStartTimeField;
            }
            set
            {
                this.raceStartTimeField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        [XmlArrayItem("Yacht", typeof(RaceParticipantsYacht), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<RaceParticipantsYacht> Participants
        {
            get
            {
                return this.participantsField;
            }
            set
            {
                this.participantsField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        [XmlArrayItem("CompoundMark", typeof(RaceCourseCompoundMark), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<RaceCourseCompoundMark> Course
        {
            get
            {
                return this.courseField;
            }
            set
            {
                this.courseField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        [XmlArrayItem("Corner", typeof(RaceCompoundMarkSequenceCorner), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<RaceCompoundMarkSequenceCorner> CompoundMarkSequence
        {
            get
            {
                return this.compoundMarkSequenceField;
            }
            set
            {
                this.compoundMarkSequenceField = value;
            }
        }

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        [XmlArrayItem("Limit", typeof(RaceCourseLimitLimit), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<RaceCourseLimitLimit> CourseLimit
        {
            get
            {
                return this.courseLimitField;
            }
            set
            {
                this.courseLimitField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [XmlType(AnonymousType = true)]
    public enum RaceRaceType
    {

        /// <remarks/>
        Match,

        /// <remarks/>
        Fleet,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RaceZoneLimit
    {

        private int seqIDField;

        private bool seqIDFieldSpecified;

        private float latField;

        private bool latFieldSpecified;

        private float lonField;

        private bool lonFieldSpecified;

        [XmlAttribute()]
        public int SeqID
        {
            get
            {
                return this.seqIDField;
            }
            set
            {
                this.seqIDField = value;
            }
        }

        [XmlIgnore()]
        public bool SeqIDSpecified
        {
            get
            {
                return this.seqIDFieldSpecified;
            }
            set
            {
                this.seqIDFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float Lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }

        [XmlIgnore()]
        public bool LatSpecified
        {
            get
            {
                return this.latFieldSpecified;
            }
            set
            {
                this.latFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float Lon
        {
            get
            {
                return this.lonField;
            }
            set
            {
                this.lonField = value;
            }
        }

        [XmlIgnore()]
        public bool LonSpecified
        {
            get
            {
                return this.lonFieldSpecified;
            }
            set
            {
                this.lonFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RaceRaceStartTime
    {

        private string startField;

        private string postponeField;

        [XmlAttribute()]
        public string Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        [XmlAttribute()]
        public string Postpone
        {
            get
            {
                return this.postponeField;
            }
            set
            {
                this.postponeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RaceParticipantsYacht
    {

        private int sourceIDField;

        private bool sourceIDFieldSpecified;

        private RaceParticipantsYachtEntry entryField;

        private bool entryFieldSpecified;

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

        [XmlIgnore()]
        public bool SourceIDSpecified
        {
            get
            {
                return this.sourceIDFieldSpecified;
            }
            set
            {
                this.sourceIDFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public RaceParticipantsYachtEntry Entry
        {
            get
            {
                return this.entryField;
            }
            set
            {
                this.entryField = value;
            }
        }

        [XmlIgnore()]
        public bool EntrySpecified
        {
            get
            {
                return this.entryFieldSpecified;
            }
            set
            {
                this.entryFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [XmlType(AnonymousType = true)]
    public enum RaceParticipantsYachtEntry
    {

        /// <remarks/>
        Port,

        /// <remarks/>
        Stbd,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RaceCourseCompoundMark
    {

        private List<RaceCourseCompoundMarkMark> markField;

        private int compoundMarkIDField;

        private bool compoundMarkIDFieldSpecified;

        private string nameField;

        public RaceCourseCompoundMark()
        {
            this.markField = new List<RaceCourseCompoundMarkMark>();
        }

        [XmlElement("Mark", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public List<RaceCourseCompoundMarkMark> Mark
        {
            get
            {
                return this.markField;
            }
            set
            {
                this.markField = value;
            }
        }

        [XmlAttribute()]
        public int CompoundMarkID
        {
            get
            {
                return this.compoundMarkIDField;
            }
            set
            {
                this.compoundMarkIDField = value;
            }
        }

        [XmlIgnore()]
        public bool CompoundMarkIDSpecified
        {
            get
            {
                return this.compoundMarkIDFieldSpecified;
            }
            set
            {
                this.compoundMarkIDFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RaceCourseCompoundMarkMark
    {

        private int seqIDField;

        private bool seqIDFieldSpecified;

        private string nameField;

        private float targetLatField;

        private bool targetLatFieldSpecified;

        private float targetLngField;

        private bool targetLngFieldSpecified;

        private int sourceIDField;

        private bool sourceIDFieldSpecified;

        [XmlAttribute()]
        public int SeqID
        {
            get
            {
                return this.seqIDField;
            }
            set
            {
                this.seqIDField = value;
            }
        }

        [XmlIgnore()]
        public bool SeqIDSpecified
        {
            get
            {
                return this.seqIDFieldSpecified;
            }
            set
            {
                this.seqIDFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        [XmlAttribute()]
        public float TargetLat
        {
            get
            {
                return this.targetLatField;
            }
            set
            {
                this.targetLatField = value;
            }
        }

        [XmlIgnore()]
        public bool TargetLatSpecified
        {
            get
            {
                return this.targetLatFieldSpecified;
            }
            set
            {
                this.targetLatFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public float TargetLng
        {
            get
            {
                return this.targetLngField;
            }
            set
            {
                this.targetLngField = value;
            }
        }

        [XmlIgnore()]
        public bool TargetLngSpecified
        {
            get
            {
                return this.targetLngFieldSpecified;
            }
            set
            {
                this.targetLngFieldSpecified = value;
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

        [XmlIgnore()]
        public bool SourceIDSpecified
        {
            get
            {
                return this.sourceIDFieldSpecified;
            }
            set
            {
                this.sourceIDFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RaceCompoundMarkSequenceCorner
    {

        private int seqIDField;

        private bool seqIDFieldSpecified;

        private int compoundMarkIDField;

        private bool compoundMarkIDFieldSpecified;

        private string roundingField;

        private int zoneSizeField;

        private bool zoneSizeFieldSpecified;

        [XmlAttribute()]
        public int SeqID
        {
            get
            {
                return this.seqIDField;
            }
            set
            {
                this.seqIDField = value;
            }
        }

        [XmlIgnore()]
        public bool SeqIDSpecified
        {
            get
            {
                return this.seqIDFieldSpecified;
            }
            set
            {
                this.seqIDFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public int CompoundMarkID
        {
            get
            {
                return this.compoundMarkIDField;
            }
            set
            {
                this.compoundMarkIDField = value;
            }
        }

        [XmlIgnore()]
        public bool CompoundMarkIDSpecified
        {
            get
            {
                return this.compoundMarkIDFieldSpecified;
            }
            set
            {
                this.compoundMarkIDFieldSpecified = value;
            }
        }

        [XmlAttribute()]
        public string Rounding
        {
            get
            {
                return this.roundingField;
            }
            set
            {
                this.roundingField = value;
            }
        }

        [XmlAttribute()]
        public int ZoneSize
        {
            get
            {
                return this.zoneSizeField;
            }
            set
            {
                this.zoneSizeField = value;
            }
        }

        [XmlIgnore()]
        public bool ZoneSizeSpecified
        {
            get
            {
                return this.zoneSizeFieldSpecified;
            }
            set
            {
                this.zoneSizeFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class RaceCourseLimitLimit
    {

        private int seqIDField;

        private float latField;

        private float lonField;

        [XmlAttribute()]
        public int SeqID
        {
            get
            {
                return this.seqIDField;
            }
            set
            {
                this.seqIDField = value;
            }
        }

        [XmlAttribute()]
        public float Lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }

        [XmlAttribute()]
        public float Lon
        {
            get
            {
                return this.lonField;
            }
            set
            {
                this.lonField = value;
            }
        }
    }
}