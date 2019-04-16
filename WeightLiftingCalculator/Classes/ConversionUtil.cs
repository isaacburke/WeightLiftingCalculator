using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Unit Conversion Tool
/// </summary>
namespace WeightLiftingCalculator.Classes // Note how the namespace mirrors folder structure in the Solution Explorer??
{
    public static class ConversionUtil
    {
        #region Constant Ratios
        const double constRatioKgToLb = 2.20462;
        const double constRatioLbToKg = .453592;
        #endregion

        /// <summary>
        /// Convert pounds to kilograms
        /// </summary>
        /// <param name="weightInPounds"></param>
        /// <returns>double</returns>
        public static double KilogramsToPounds(double weightInPounds)
        {
            return weightInPounds * constRatioKgToLb;
        }

        /// <summary>
        /// Convert kilograms to pounds
        /// </summary>
        /// <param name="weightInKilograms"></param>
        /// <returns>double</returns>
        public static double PoundsToKilograms(double weightInKilograms)
        {
            return weightInKilograms * constRatioLbToKg;
        }
    }
}
