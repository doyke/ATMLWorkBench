// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 4.0.0.283
//    <NameSpace>ATMLCommonLibrary.model.common</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><InitializeFields>None</InitializeFields><GenerateUnusedComplexTypes>True</GenerateUnusedComplexTypes><GenerateUnusedSimpleTypes>True</GenerateUnusedSimpleTypes><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>True</OrderXMLAttrib><EnableLazyLoading>False</EnableLazyLoading><VirtualProp>False</VirtualProp><PascalCase>False</PascalCase><AutomaticProperties>False</AutomaticProperties><PropNameSpecified>Default</PropNameSpecified><PrivateFieldName>StartWithUnderscore</PrivateFieldName><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>True</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><EnableExternalSchemasCache>False</EnableExternalSchemasCache><EnableDebug>False</EnableDebug><EnableWarn>False</EnableWarn><ExcludeImportedTypes>True</ExcludeImportedTypes><ExpandNesteadAttributeGroup>False</ExpandNesteadAttributeGroup><CleanupCode>True</CleanupCode><EnableXmlSerialization>True</EnableXmlSerialization><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><EnableEncoding>False</EnableEncoding><EnableXMLIndent>False</EnableXMLIndent><Encoder>UTF8</Encoder><Serializer>XmlSerializer</Serializer><GenerateShouldSerialize>False</GenerateShouldSerialize><BaseClassName>EntityBase</BaseClassName><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><CustomUsings>ATMLCommonLibrary.model.common;ATMLCommonLibrary.model.equipment</CustomUsings>
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace ATMLModelLibrary.model.common
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using ATMLModelLibrary.model.common;
    using ATMLModelLibrary.model.equipment;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "urn:IEEE-1671:2010:Capabilities")]
    [XmlRootAttribute("Capabilities", Namespace = "urn:IEEE-1671:2010:Capabilities", IsNullable = false)]
    public partial class Capabilities1 : Capabilities
    {

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _version;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _name;

        [EditorBrowsable(EditorBrowsableState.Never)]
        private string _uuid;

        private static XmlSerializer serializer;

        [XmlAttribute]
        public string version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }

        [XmlAttribute]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        [XmlAttribute]
        public string uuid
        {
            get
            {
                return _uuid;
            }
            set
            {
                _uuid = value;
            }
        }

        private static XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new XmlSerializer(typeof(Capabilities1));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current Capabilities1 object into an XML string
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try
            {
                memoryStream = new MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an Capabilities1 object
        /// </summary>
        /// <param name="input">string workflow markup to deserialize</param>
        /// <param name="obj">Output Capabilities1 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string input, out Capabilities1 obj, out Exception exception)
        {
            exception = null;
            obj = default(Capabilities1);
            try
            {
                obj = Deserialize(input);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string input, out Capabilities1 obj)
        {
            Exception exception;
            return Deserialize(input, out obj, out exception);
        }

        public new static Capabilities1 Deserialize(string input)
        {
            StringReader stringReader = null;
            try
            {
                stringReader = new StringReader(input);
                return ((Capabilities1)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        public static Capabilities1 Deserialize(Stream s)
        {
            return ((Capabilities1)(Serializer.Deserialize(s)));
        }
        #endregion

        /// <summary>
        /// Serializes current Capabilities1 object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveToFile(string fileName)
        {
            StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                FileInfo xmlFile = new FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an Capabilities1 object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Capabilities1 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this Serializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Capabilities1 obj, out Exception exception)
        {
            exception = null;
            obj = default(Capabilities1);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out Capabilities1 obj)
        {
            Exception exception;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public new static Capabilities1 LoadFromFile(string fileName)
        {
            FileStream file = null;
            StreamReader sr = null;
            try
            {
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
    }
}
#pragma warning restore
