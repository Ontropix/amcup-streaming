// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>StreamParser</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace AmericasCup.Streaming.Xsd
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class RegattaConfig
    {

        private int regattaIDField;

        private string regattaNameField;

        private string courseNameField;

        private float centralLatitudeField;

        private float centralLongitudeField;

        private float centralAltitudeField;

        private float utcOffsetField;

        private float magneticVariationField;

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public int RegattaID
        {
            get
            {
                return this.regattaIDField;
            }
            set
            {
                this.regattaIDField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string RegattaName
        {
            get
            {
                return this.regattaNameField;
            }
            set
            {
                this.regattaNameField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string CourseName
        {
            get
            {
                return this.courseNameField;
            }
            set
            {
                this.courseNameField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public float CentralLatitude
        {
            get
            {
                return this.centralLatitudeField;
            }
            set
            {
                this.centralLatitudeField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public float CentralLongitude
        {
            get
            {
                return this.centralLongitudeField;
            }
            set
            {
                this.centralLongitudeField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public float CentralAltitude
        {
            get
            {
                return this.centralAltitudeField;
            }
            set
            {
                this.centralAltitudeField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public float UtcOffset
        {
            get
            {
                return this.utcOffsetField;
            }
            set
            {
                this.utcOffsetField = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        public float MagneticVariation
        {
            get
            {
                return this.magneticVariationField;
            }
            set
            {
                this.magneticVariationField = value;
            }
        }
    }
}
