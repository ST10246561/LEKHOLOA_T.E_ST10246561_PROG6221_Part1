using System;

public class Ingredients
{
	public Ingredients()
	{
		private static string theName;
		private static int theQuantity;
		private static string unitMeasurement;
        

		public string getTheName()
	{
		return getTheName();
	}

    public void setTheName(string theName)
    {
        this.setTheName = theName;
    }

    public int gettheQuantity()
    {
        return getTheQuantity();
    }


    public void settheQuantity (int theQuantity)
    {
        this.settheQuantity = theQuantity;
    }

    public string getunitMeasurement()
    {
        return getUnitMeasurement();
    }

    public void setunitMeasurement(string unitMeasurement)
    {
        this.setUnitMeasurement = unitMeasurement;
    }


    public static void DisplayFullRecipe()
    {
        Console.WriteLine("_____ FULL RECIPE_____ \n" +
            'n\ ' + "Name: " + theName +
            'n\ ' + "Quantity" + theQuantity +
            'n\ ' + "Unint Measurement" + unintMeasurement);
        }





























}
}
