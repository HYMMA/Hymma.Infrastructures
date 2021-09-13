namespace Hymma.CADWorks.Geometry.Core
{
    /// <summary>
    /// In geometry, the notion of line or straight line was introduced by ancient mathematicians to represent straight objects (i.e., having no curvature) with negligible width and depth. <br/>
    /// Lines are an idealization of such objects, which are often described in terms of two points
    /// </summary>
    public interface ILine : ICurve
    {
        /// <summary>
        /// point 1 to define a line in space
        /// </summary>
        ICoordinate Coord1 { get; }

        /// <summary>
        /// point 2 to define a line in space
        /// </summary>
        ICoordinate Coord2 { get; }
    }
}
