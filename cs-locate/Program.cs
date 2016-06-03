// OLOCATE - Get or set Cursor location in Windows Console
using System;

namespace orez.locate {
	class Program {
		static void Main(string[] args) {
			// process input
			var x = args.Length >= 1 ? args[0] : "+0";
			var y = args.Length >= 2 ? args[1] : "+0";
			var xv = (x[0] == '+' || x[0] == '-' ? Console.CursorLeft : 0) + int.Parse(x);
			var yv = (y[0] == '+' || y[0] == '-' ? Console.CursorTop : 0) + int.Parse(y);
			// get or set position
			if(args.Length == 0) Console.WriteLine(xv + " " + yv);
			else Console.SetCursorPosition(xv < 0 ? 0 : xv, yv < 0 ? 0 : yv);
		}
	}
}
