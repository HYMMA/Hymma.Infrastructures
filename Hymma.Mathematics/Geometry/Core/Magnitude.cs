

using System.Drawing;

namespace Hymma.Mathematics.Geometry.Core
{
    public struct Magnitude 
    {
        public static Magnitude Value(double value)
        {

        }
        /// <summary>
        /// numeric value of this struct
        /// </summary>
        public double Value { get; set; }

        //
        // Summary:
        //     Adds the width and height of one System.Drawing.Size structure to the width and
        //     height of another System.Drawing.Size structure.
        //
        // Parameters:
        //   sz1:
        //     The first System.Drawing.Size structure to add.
        //
        //   sz2:
        //     The second System.Drawing.Size structure to add.
        //
        // Returns:
        //     A System.Drawing.Size structure that is the result of the addition operation.
        public static Magnitude Add(Magnitude mg1, Magnitude mg2) => mg1.Value + mg2.Value;
        
        //
        // Summary:
        //     Converts the specified System.Drawing.SizeF structure to a System.Drawing.Size
        //     structure by rounding the values of the System.Drawing.Size structure to the
        //     next higher integer values.
        //
        // Parameters:
        //   value:
        //     The System.Drawing.SizeF structure to convert.
        //
        // Returns:
        //     The System.Drawing.Size structure this method converts to.
        public static Magnitude Ceiling(MagnitudeF value);
        //
        // Summary:
        //     Converts the specified System.Drawing.SizeF structure to a System.Drawing.Size
        //     structure by rounding the values of the System.Drawing.SizeF structure to the
        //     nearest integer values.
        //
        // Parameters:
        //   value:
        //     The System.Drawing.SizeF structure to convert.
        //
        // Returns:
        //     The System.Drawing.Size structure this method converts to.
        public static Size Round(SizeF value);
        //
        // Summary:
        //     Subtracts the width and height of one System.Drawing.Size structure from the
        //     width and height of another System.Drawing.Size structure.
        //
        // Parameters:
        //   sz1:
        //     The System.Drawing.Size structure on the left side of the subtraction operator.
        //
        //   sz2:
        //     The System.Drawing.Size structure on the right side of the subtraction operator.
        //
        // Returns:
        //     A System.Drawing.Size structure that is a result of the subtraction operation.
        public static Size Subtract(Size sz1, Size sz2);
        //
        // Summary:
        //     Converts the specified System.Drawing.SizeF structure to a System.Drawing.Size
        //     structure by truncating the values of the System.Drawing.SizeF structure to the
        //     next lower integer values.
        //
        // Parameters:
        //   value:
        //     The System.Drawing.SizeF structure to convert.
        //
        // Returns:
        //     The System.Drawing.Size structure this method converts to.
        public static Size Truncate(SizeF value);
        //
        // Summary:
        //     Tests to see whether the specified object is a System.Drawing.Size structure
        //     with the same dimensions as this System.Drawing.Size structure.
        //
        // Parameters:
        //   obj:
        //     The System.Object to test.
        //
        // Returns:
        //     true if obj is a System.Drawing.Size and has the same width and height as this
        //     System.Drawing.Size; otherwise, false.
        public override bool Equals(object obj);
        //
        // Summary:
        //     Returns a hash code for this System.Drawing.Size structure.
        //
        // Returns:
        //     An integer value that specifies a hash value for this System.Drawing.Size structure.
        public override int GetHashCode();
        //
        // Summary:
        //     Creates a human-readable string that represents this System.Drawing.Size structure.
        //
        // Returns:
        //     A string that represents this System.Drawing.Size.
        public override string ToString();

        //
        // Summary:
        //     Adds the width and height of one System.Drawing.Size structure to the width and
        //     height of another System.Drawing.Size structure.
        //
        // Parameters:
        //   sz1:
        //     The first System.Drawing.Size to add.
        //
        //   sz2:
        //     The second System.Drawing.Size to add.
        //
        // Returns:
        //     A System.Drawing.Size structure that is the result of the addition operation.
        public static Size operator +(Size sz1, Size sz2);
        //
        // Summary:
        //     Subtracts the width and height of one System.Drawing.Size structure from the
        //     width and height of another System.Drawing.Size structure.
        //
        // Parameters:
        //   sz1:
        //     The System.Drawing.Size structure on the left side of the subtraction operator.
        //
        //   sz2:
        //     The System.Drawing.Size structure on the right side of the subtraction operator.
        //
        // Returns:
        //     A System.Drawing.Size structure that is the result of the subtraction operation.
        public static Size operator -(Size sz1, Size sz2);
        //
        // Summary:
        //     Tests whether two System.Drawing.Size structures are equal.
        //
        // Parameters:
        //   sz1:
        //     The System.Drawing.Size structure on the left side of the equality operator.
        //
        //   sz2:
        //     The System.Drawing.Size structure on the right of the equality operator.
        //
        // Returns:
        //     true if sz1 and sz2 have equal width and height; otherwise, false.
        public static bool operator ==(Size sz1, Size sz2);
        //
        // Summary:
        //     Tests whether two System.Drawing.Size structures are different.
        //
        // Parameters:
        //   sz1:
        //     The System.Drawing.Size structure on the left of the inequality operator.
        //
        //   sz2:
        //     The System.Drawing.Size structure on the right of the inequality operator.
        //
        // Returns:
        //     true if sz1 and sz2 differ either in width or height; false if sz1 and sz2 are
        //     equal.
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public static bool operator !=(Size sz1, Size sz2);

        //
        // Summary:
        //     Converts the specified System.Drawing.Size structure to a System.Drawing.SizeF
        //     structure.
        //
        // Parameters:
        //   p:
        //     The System.Drawing.Size structure to convert.
        //
        // Returns:
        //     The System.Drawing.SizeF structure to which this operator converts.
        public static implicit operator SizeF(Size p);
        //
        // Summary:
        //     Converts the specified System.Drawing.Size structure to a System.Drawing.Point
        //     structure.
        //
        // Parameters:
        //   size:
        //     The System.Drawing.Size structure to convert.
        //
        // Returns:
        //     The System.Drawing.Point structure to which this operator converts.
        public static explicit operator Point(Size size);
    }
}
