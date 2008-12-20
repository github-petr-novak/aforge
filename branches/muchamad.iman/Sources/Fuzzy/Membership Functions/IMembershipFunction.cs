// AForge Fuzzy Library
// AForge.NET framework
//
// Copyright � Andrew Kirillov, 2005-2008 
// andrew.kirillov@gmail.com 
//
// Copyright � Fabio L. Caversan, 2008
// fabio.caversan@gmail.com
//
namespace AForge.Fuzzy
{
    using System;

    /// <summary>
    /// Interface which specifies set of methods required to be implemented by all membership
    /// functions.
    /// </summary>
    /// 
    /// <remarks><para>All membership functions must implement this interface, which is used by
    /// <see cref="FuzzySet"/> class to calculate value's membership to a particular fuzzy set.
    /// </para></remarks>
    /// 
    public interface IMembershipFunction
    {
        /// <summary>
        /// Calculate membership of a given value to the fuzzy set.
        /// </summary>
        /// 
        /// <param name="x">Value which membership will to be calculated.</param>
        /// 
        /// <returns>Degree of membership [0..1] of the value to the fuzzy set.</returns>
        /// 
        double GetMembership( double x );

        /// <summary>
        /// The leftmost x value of the membership function.
        /// </summary>
        double LeftLimit { get; }

        /// <summary>
        /// The rightmost x value of the membership function.
        /// </summary>
        double RightLimit { get; }
    }
}
