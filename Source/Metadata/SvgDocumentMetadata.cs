﻿using System.Xml;

namespace Svg
{
    /// <summary>
    /// Represents a list of re-usable SVG components.
    /// </summary>
    [SvgElement("metadata")]
    public partial class SvgDocumentMetadata : SvgElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgDocumentMetadata"/> class.
        /// </summary>
        public SvgDocumentMetadata()
        {
            Content = string.Empty;
        }

        protected override void WriteChildren(XmlWriter writer)
        {
            writer.WriteRaw(this.Content); // write out metadata as is
        }

        public override SvgElement DeepCopy()
        {
            return DeepCopy<SvgDocumentMetadata>();
        }

        public override void InitialiseFromXML(XmlReader reader, SvgDocument document)
        {
            base.InitialiseFromXML(reader, document);

            // read in the metadata just as a string ready to be written straight back out again
            Content = reader.ReadInnerXml();
        }
    }
}
