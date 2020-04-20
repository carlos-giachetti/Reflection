using ACME.Interfaces;


namespace ACME.Libraries
{
	class Example_A : IExample
	{
		public Example_A()
		{
		}

		public string Output()
		{
			return "ACME.Libraries.Example_A.Output()";
		}
	}
}
