using System;

namespace Hymma.Mathematics
{
    /// <summary>
    /// an <see cref="IPoint"/> from (0,0,0)
    /// </summary>
    public struct Origin : IPoint
    {
        ///<inheritdoc/> 
        public double X { get => 0; set => throw new FieldAccessException("Cannot assign value to origin, it is always Zero"); }

        ///<inheritdoc/> 
        public double Y { get => 0; set => throw new FieldAccessException("Cannot assign value to origin, it is always Zero"); }

        ///<inheritdoc/> 
        public double Z { get => 0; set => throw new FieldAccessException("Cannot assign value to origin, it is always Zero"); }

        ///<inheritdoc/> 
        public IPoint Plus(IPoint point)
        {
            return point;
        }

        ///<inheritdoc/> 
        public IPoint Minus(IPoint point)
        {
            return point;
        }

        /// <returns>( 0 , 0 , 0 )</returns>
        public override string ToString()
        {
            return ("( 0 , 0 , 0 )");
        }
    }
}
