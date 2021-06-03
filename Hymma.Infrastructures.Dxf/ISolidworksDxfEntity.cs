using System;
using System.Collections.Generic;

namespace Hymma.Infrastructures.Dxf
{
    public interface ISolidworksDxfEntity : IEquatable<ISolidworksDxfEntity>
    {
        /// <summary>
        /// title of this dxf entity as shown in solidworks
        /// </summary>
        string ModelTitle { get; set; }

        /// <summary>
        /// the directory where the dxf file gets saved in
        /// </summary>
        string directory { get; set; }

        /// <summary>
        /// required quantity of this entity
        /// </summary>
        int Qty { get; set; }

        /// <summary>
        /// Path and filename of the exported DXF/DWG file
        /// </summary>
        string FullFileName { get; set; }

        /// <summary>
        /// flatPattern in real sheetMetals and bossExtrude or ref feature in faces
        /// </summary>
        string FeatureName { get; set; }

        /// <summary>
        /// represents the body2 object or body name
        /// </summary>
        string BodyTitle { get; set; }

        /// <summary>
        /// thickness of this dxf component in mm
        /// </summary>
        double Thickness { get; set; }

        /// <summary>
        /// Material as defined by user, if face is selected should be blank
        /// </summary>
        string Material { get; set; }

        /// <summary>
        /// configuration that is refrenced in the component 
        /// </summary>
        string ReferencedConfiguration { get; set; }

        /// <summary>
        /// Path and filename of the part document
        /// </summary>
        string ModelPathName { get; set; }

        /// <summary>
        /// determines if this was a sheetMetal component in CAD
        /// </summary>
        bool IsSheetMetal { get; set; }

        /// <summary>
        /// True to save as one file; false to save as multiple files
        /// </summary>
        bool ExportToSingleFile { get; set; }

        /// <summary>
        /// True to flip the x direction; false otherwise
        /// </summary>
        bool IsXDirFlipped { get; set; }

        /// <summary>
        /// True to flip the y direction; false otherwise
        /// </summary>
        bool IsYDirFlipped { get; set; }

        /// <summary>
        /// Bitmask that contains sheet metal export options; valid only if Action = swExportToDWG_e.swExportToDWG_ExportSheetMetal
        /// </summary>
        int SheetMetalOptions { get; set; }

        /// <summary>
        /// Array of annotation view names to export; valid only if Action = swExportToDWG_e.swExportToDWG_ExportAnnotationViews
        /// </summary>
        object Views { get; set; }

        /// <summary>
        /// Export action as defined in swExportToDWG_e
        /// <list type="bullet">
        /// <item>
        /// <term>swExportToDWG_ExportAnnotationViews</term>
        /// <description>3</description>
        /// </item>
        /// 
        /// <item>
        /// <term>swExportToDWG_ExportSelectedFacesOrLoops</term>
        /// <description>2</description>
        /// </item>  
        /// 
        /// <item>
        /// <term>swExportToDWG_ExportSheetMetal</term>
        /// <description>1; Valid only if the active document contains sheet metal</description>
        /// </item>
        /// </list>
        /// </summary>
        int Action { get; set; }

        /// <summary>
        /// Array of 12 double values that contain information related to output alignment<br/>
        ///Array[0], Array[1], Array[2] - x,y,z coordinates of new origin<br/>
        ///Array[3], Array[4], Array[5] - coordinates of new x direction vector<br/>
        ///Array[6], Array[7], Array[8] - coordinates of new y direction vector<br/>
        ///Array[9], Array[10], Array[11] - coordinates of the vector that is normal to the selected faces or loops<br/>
        /// </summary>
        double[] Alignment { get; set; }

        /// <summary>
        /// dtermines if this file will overwrite previous files on the machine if they already exist
        /// </summary>
        bool CanOverWriteFiles { get; set; }

        /// <summary>
        /// unit of measure in this dxf entity (mm, in, m , ...)
        /// </summary>
        string LengthUnit { get; set; }

        /// <summary>
        /// will cut bendlines back upon dxf creation. </br> this property is valid only if the bendlines are set to be exported in <see cref="SheetMetalOptions_e"/>
        /// </summary>
        bool ModifyBendLines { get; set; }

        /// <summary>
        /// this methode ensures tangent faces of the output entity is seleceted
        /// </summary>
        bool SelectTangentFaces { get; set; }

        /// <summary>
        /// this is a dictionary of solidworks part property and its value that we can use to insert into an MText into dxf file.
        /// </summary>
        Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// A dicitonary of bendLine points, key is the start points and value would be the end points<br/>
        /// this is empty if <see cref="ModifyBendLines"/> ==false
        /// </summary>
        Dictionary<double[], double[]> BendLinePoints { get; set; }

        /// <summary>
        /// A list of bend_line data where for each bendline
        /// <list type="bullet">
        /// <item>BendData[0]<description> : is the color </description></item>
        /// <item>BendData[1]<description> : is the Style Index </description></item>
        /// <item>BendData[2]<description> : is the Layer </description></item>
        /// </list>
        /// </summary>
        List<string[]> BendsData { get; set; }
    }
}