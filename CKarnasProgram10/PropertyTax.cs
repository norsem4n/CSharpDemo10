/* CIS 605 Homework Set 5 - Program 10
 * Created By:      Christopher Karnas
 * Date Created:    October 2020
 * Last Modified:   10.21.2020
 * Class Name:      PropertyTax
 * Description:     Calcualtes the property tax of a property
 */
using System;

namespace CKarnasProgram10
{
    #region"Enumeration"
    public enum LocationType
    {
        // enumeration for 3 location types (outside class)

        City = 1,
        Suburb = 2,
        Rural = 3
    }
    #endregion

    class PropertyTax
    {
        #region "Fields"
        // 5 read only fields

        public readonly string OwnerName;
        public readonly int BldgSqFt;
        public readonly int LandSqFt;
        public readonly int YearBuilt;
        public readonly LocationType PropLocation;

        #endregion

        #region "Properties"
        // 6 auto implemented properties

        public int BuildingAge { get; private set; }
        public decimal BldgTax { get; private set; }
        public decimal BldgTaxDeduction { get; private set; }
        public decimal LandTax { get; private set; }
        public decimal LandTaxDeduction { get; private set; }
        public decimal TotalPropTax { get; private set; }

        #endregion

        #region "Constructor"
        // instantiate object, set instance properties

        public PropertyTax(string owner, int bldgSqFt, int landSqFt, int yearBuilt, LocationType propType)
        {
            OwnerName = owner;
            BldgSqFt = bldgSqFt;
            LandSqFt = landSqFt;
            YearBuilt = yearBuilt;
            PropLocation = propType;

            BuildingAge = DateTime.Now.Year - YearBuilt;

            // call the TotalPropertyTax method

            CalculatePropertyTax();
        
        }
        #endregion

        #region "Private Methods"
        
        // calculate and set Building tax
        private void CalculateBldgTax()
        {
            //decimal bldgTax = 0;
            if (BldgSqFt <= 1000)
            {
                BldgTax = BldgSqFt * 0.71m;
            }
            else if (BldgSqFt <= 2000)
            {
                BldgTax = (BldgSqFt - 1000) * 0.73m + 710;
            }
            else if (BldgSqFt <= 3000)
            {
                BldgTax = (BldgSqFt - 2000) * 0.75m + 1440;
            }
            else if (BldgSqFt <= 4000)
            {
                BldgTax = (BldgSqFt - 3000) * 0.77m + 2190;
            }
            else
            {
                BldgTax = (BldgSqFt - 4000) * 0.80m + 2960;
            }
        }

        // calculcate and set Land tax

        private void CalculateLandTax()
        {
            if (LandSqFt <= 10000)
            { 
                LandTax = LandSqFt * 0.04m; 
            }
            else if (LandSqFt <= 20000)
            { 
                LandTax = (LandSqFt - 10000) * 0.06m + 400; 
            }
            else if (LandSqFt <= 30000)
            { 
                LandTax = (LandSqFt - 20000) * 0.08m + 1000; 
            }
            else if (LandSqFt <= 40000)
            {
                LandTax = (LandSqFt - 30000) * 0.1m + 1800;
            }
            else
            {
                LandTax = ((LandSqFt - 40000) * 0.13m) + 2800;
            }
        }

        // calculate and set building tax deduction

        private void CalcBuildingTaxDeduction()
        {
            BldgTaxDeduction = BuildingAge * (0.005M * BldgTax);
        }

        // calculate and set land tax deduction
        private void CalcLandTaxDeduction()
        {
            //2.5 percent of the land tax is deducted for land sizes less than or equal to 22,250 square feet
            //1.75 percent of the land tax is deducted for land sizes greater than 22, 250 square feet

            //CalculateLandTax();

            if (LandSqFt >= 22250)
            {
                LandTaxDeduction = 0.025m * LandTax;
            }
            else if (LandSqFt < 22250)
            {
                LandTaxDeduction = 0.0175m * LandTax;
            }
        }

        //calculate total property tax
        private void CalculatePropertyTax()
        {
            // call the private methods that calculate and set the building and land taxes
            CalculateBldgTax();
            CalculateLandTax();

            // Conditionally (i.e., if the building age > 15) call the method that calculates and sets the building tax deduction

            if (BuildingAge >= 15)
            {
                CalcBuildingTaxDeduction();
            }


            // Conditionally (i.e., if the property’s location is rural) call the method that calculates and sets the land tax deduction

            if (PropLocation == LocationType.Rural)
            {
                CalcLandTaxDeduction();
            }


            // Calculate and set the total property tax (building tax + land tax – building tax deduction – land tax deduction)

            TotalPropTax = BldgTax + LandTax - BldgTaxDeduction - LandTaxDeduction;

            //decimal totalPropTax = BldgTax + LandTax - BldgTaxDeduction - LandTaxDeduction;
            //return totalPropTax;
        }
        #endregion
    }
}
