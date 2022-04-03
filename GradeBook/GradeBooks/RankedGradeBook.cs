using GradeBook.Enums;
using System;
using  System.Linq;

namespace GradeBook.GradeBooks
{
	public class RankedGradeBook : BaseGradeBook
	{
		public RankedGradeBook(string name,bool isWeighted) : base(name, isWeighted)
		{
			Type = GradeBookType.Ranked;
		}

		
	}
}