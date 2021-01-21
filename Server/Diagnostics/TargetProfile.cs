using System;
using System.Collections.Generic;

namespace Server.Diagnostics
{
	public class TargetProfile : BaseProfile
	{
		private static Dictionary<Type, TargetProfile> _profiles = new Dictionary<Type, TargetProfile>();

		public static IEnumerable<TargetProfile> Profiles
		{
			get
			{
				return _profiles.Values;
			}
		}

		public static TargetProfile Acquire(Type type)
		{
			if (!Core.Profiling)
			{
				return null;
			}

			if (!_profiles.TryGetValue(type, out TargetProfile prof))
			{
				_profiles.Add(type, prof = new TargetProfile(type));
			}

			return prof;
		}

		public TargetProfile(Type type)
			: base(type.FullName)
		{
		}
	}
}
