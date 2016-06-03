using System;

namespace orez.locate {
	class Program {
		static void Main(string[] args) {
			var x = args.Length >= 2 ? args[1] : "+0";
			var y = args.Length >= 3 ? args[2] : "+0";
			var xv = (x[0] == '+' || x[0] == '-' ? Console.CursorLeft : 0) + Int32.Parse(x);
			var yv = (y[0] == '+' || y[0] == '-' ? Console.CursorTop : 0) + Int32.Parse(y);
			if(args.Length == 1) Console.WriteLine(xv + " " + yv);
			else Console.SetCursorPosition(xv < 0 ? 0 : xv, yv < 0 ? 0 : yv);
		}
	}
}
