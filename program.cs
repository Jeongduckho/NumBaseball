using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbaseball {
	class Program {
		public static int tempcode;
		static void mv() {
			Console.Write("     ");
		}
		static void printline(char symbol, int length) {
			int p;
			for (p = 0; p < length; p++) {
				Console.Write(symbol);
			}
			Console.WriteLine();
		}
		static void mkrandnum(int i) {
			int p, q = 0;
			Random r = new Random(DateTime.Now.Millisecond);
			int[] n = new int[i + 1];
			n[0] = r.Next(0, 9);
			for (p = 1; p <= i; p++) {
				n[p] = r.Next(0, 9);
				for (q = 0; q < p; q++) {
					if (n[p] == n[q] | n[0] == n[p]) {
						p--;
						break;
					}
				}
			}
		}
		static void getusernum(int i) {
			int p, q;
			int[] user = new int[i + 1];
			Console.WriteLine();
			if (tempcode != 1) {
				mv();
				printline('-', 46);
				Console.WriteLine("     자리수 만큼 한 자리씩 숫!자!로! 입력해주세요.");
				mv();
				printline('-', 46);
				Console.WriteLine();
			}
			for (p = 0; p <= i; p++) {
				Console.Write("     {0}의 자리 : ", i + 1 - p);
				user[p] = Convert.ToInt32(Console.ReadLine());
				if (user[p] >= 10 | char.IsDigit((char) user[p]) == true) {
					Console.WriteLine("     10미만의 수만 입력가능합니다.");
					p--;
				}
				if (char.IsDigit((char) user[p]) != true) {
					for (q = 0; q <= p; q++) {
						if (user[p] == user[q] && p != q) {
							Console.WriteLine("     숫자가 중복되었습니다.");
							Console.WriteLine("      다른 수를 넣어주세요.");
							p--;
							break;
						}
					}
				}
			}
		}
		static void Main(string[] args) {
			int i;
			mv();
			printline('@', 49);
			Console.WriteLine("                세상에서 가장 어려운 숫자야구              ");
			mv();
			printline('@', 49);
			Console.WriteLine("");
			Console.Write("             * Easy");
			Console.WriteLine("             * Medium\n");
			Console.WriteLine("");
			Console.Write("          1)    두자리");
			Console.WriteLine("          3)    네자리\n");
			Console.Write("          2)    세자리");
			Console.WriteLine("          4)   다섯자리\n");
			Console.WriteLine("");
			Console.Write("             * Hard");
			Console.WriteLine("             * Hell\n");
			Console.WriteLine("");
			Console.Write("          5)   여섯자리");
			Console.WriteLine("          7)   여덟자리\n");
			Console.Write("          6)   일곱자리");
			Console.WriteLine("          8)   아홉자리\n");
			Console.WriteLine("");
			Console.WriteLine("                      0)      종료");
			Console.WriteLine("");
			mv();
			printline('@', 49);
			Console.WriteLine("");
			Console.Write("           :");
			i = Convert.ToInt32(Console.ReadLine());
			if (i == 0) {
				return;
			}
			mkrandnum(i);
			getusernum(i);
			Console.ReadLine();
		}
	}
}
