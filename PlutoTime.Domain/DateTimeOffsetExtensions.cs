using System;

namespace PlutoTime.Domain
{
	public static class DateTimeOffsetExtensions
	{
		/// <summary>
		/// Calculates the current Julian Tie
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <param name="dateTimeOffset"></param>
		/// <returns></returns>
		public static double GetJulianDate(this DateTimeOffset dateTimeOffset)
		{
			// 2440587.5 days + UNIX TIME in days === Julian Day
			var unixTimeSeconds = dateTimeOffset.ToUnixTimeMilliseconds();
			var unixDays = TimeSpan.FromMilliseconds(unixTimeSeconds).TotalDays;
			return unixDays + 2440587.5;
		}
	}
}
