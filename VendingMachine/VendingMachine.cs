using System;

namespace VendingMachine
{
    class VendingMachine
    {
        // private instance variables
        private int numQuarters, almoundJoy, butterFinger, twix, snickers;

        internal enum CandyBar
        {
            AlmoundJoy,
            ButterFinger,
            Twix,
            Snickers
        }

        // Public noarg constructor
        public VendingMachine()
        {
            // Set the candy bar cost in quarters.  
            numQuarters = 0;

            // Set initial number of candy bars.
            almoundJoy = 5;
            butterFinger = 5;
            twix = 5;
            snickers = 5;

        }

        // Public read only properties:
        public int NumQuarters
        {
            get { return numQuarters; }
        }

        public int AlmoundJoy
        {
            get { return almoundJoy; }
        }

        public int ButterFinger
        {
            get { return butterFinger; }
        }

        public int Twix
        {
            get { return twix; }
        }

        public int Snickers
        {
            get { return snickers; }
        }

        // Public methods:

        public string DepositQuarter()
        {
            numQuarters++;
            return "Quarter deposited.";
        }

        public string SelectCandy(CandyBar candyBar)
        {
            var output = String.Empty;
            if (numQuarters >= 3 && (almoundJoy > 0 || butterFinger > 0 || twix > 0 || snickers > 0))
            {
                //switch on the CandyBar and subtracts 1 from the correct candybar.
                switch (candyBar)
                {
                    case CandyBar.AlmoundJoy:
                        if (almoundJoy > 0)
                        {
                            SubtractQuarter();
                            almoundJoy--;
                            output = "Almond Joy candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            output = "No Almond Joy candy bars in machine.";
                            break;
                        }
                    case CandyBar.ButterFinger:
                        if (butterFinger > 0)
                        {
                            SubtractQuarter();
                            butterFinger--;
                            output = "Butterfinger candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            output = "No Butterfinger candy bars in machine.";
                            break;
                        }
                    case CandyBar.Twix:
                        if (twix > 0)
                        {
                            SubtractQuarter();
                            twix--;
                            output = "Twix candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            output = "No Twix candy bars in machine.";
                            break;
                        }
                    case CandyBar.Snickers:
                        if (snickers > 0)
                        {
                            SubtractQuarter();
                            snickers--;
                            output = "Snickers candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            output = "No Snickers candy bars in machine.";
                            break;
                        }
                }
                return output;
            }
            else if (numQuarters < 3)
            {
                return "Not enough quarters to buy candy bar.";
            }
            else
            {
                return "No candy bars in machine.";
            }
        }

        // Subtracts 3 from the number of quarters
        public void SubtractQuarter()
        {
            numQuarters = numQuarters - 3;
        }

        public override string ToString()
        {
            return "Total Quarters: " + numQuarters + "\n"
                + "Almond Joy: " + almoundJoy + "\n"
                + "Butterfinger: " + butterFinger + "\n"
                + "Twix: " + twix + "\n"
                + "Snickers: " + snickers + "\n";
        }
    }
}
