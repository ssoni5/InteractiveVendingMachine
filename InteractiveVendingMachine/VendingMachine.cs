using System;

namespace VendingMachine
{
    class VendingMachine
    {
        // private instance variables
        private int numQuarters, almoundJoy, butterFinger, twix, snickers, totalCandyBarsVended;
        private double totalMoneyCollected;
        private string messageOutput;

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
            totalMoneyCollected = 0;
            messageOutput = String.Empty;

            // Set initial number of candy bars.
            totalCandyBarsVended = 0;
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

        public int TotalCandyBarsVended
        {
            get { return totalCandyBarsVended; }
        }

        public string TotalMoneyCollected
        {
            get { return totalMoneyCollected.ToString("C"); }
        }

        public string MessageOutput
        {
            get { return messageOutput; }
        }

        // Public methods:
        public string DepositQuarter()
        {
            numQuarters++;
            totalMoneyCollected = totalMoneyCollected + 0.25;
            messageOutput = String.Empty;
            return "Quarter deposited.";
        }

        public string SelectCandy(CandyBar candyBar)
        {
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
                            TrackTotalCandyBar();
                            messageOutput = "Almond Joy candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            messageOutput = "No Almond Joy candy bars in machine.";
                            break;
                        }
                    case CandyBar.ButterFinger:
                        if (butterFinger > 0)
                        {
                            SubtractQuarter();
                            butterFinger--;
                            TrackTotalCandyBar();
                            messageOutput = "Butterfinger candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            messageOutput = "No Butterfinger candy bars in machine.";
                            break;
                        }
                    case CandyBar.Twix:
                        if (twix > 0)
                        {
                            SubtractQuarter();
                            twix--;
                            TrackTotalCandyBar();
                            messageOutput = "Twix candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            messageOutput = "No Twix candy bars in machine.";
                            break;
                        }
                    case CandyBar.Snickers:
                        if (snickers > 0)
                        {
                            SubtractQuarter();
                            snickers--;
                            TrackTotalCandyBar();
                            messageOutput = "Snickers candy bar dispensed.";
                            break;
                        }
                        else
                        {
                            messageOutput = "No Snickers candy bars in machine.";
                            break;
                        }
                }
                return messageOutput;
            }
            else if (numQuarters < 3)
            {

                return messageOutput = "Not enough quarters to buy candy bar.";
            }
            else
            {
                return messageOutput = "No candy bars in machine.";
            }
        }

        // Subtracts 3 from the number of quarters
        public void SubtractQuarter()
        {
            numQuarters = numQuarters - 3;
        }

        public void TrackTotalCandyBar()
        {
            totalCandyBarsVended++;
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
