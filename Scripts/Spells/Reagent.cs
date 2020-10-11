using System;
using Server.Items;

namespace Server.Spells
{
	public enum Reg
	{
		BlackPearl,
		Bloodmoss,
		Garlic,
		Ginseng,
		MandrakeRoot,
		Nightshade,
		SulfurousAsh,
		SpidersSilk,
		BatWing,
		GraveDust,
		DaemonBlood,
		NoxCrystal,
		PigIron,
		Bone,
		FertileDirt,
		DragonBlood,
		DaemonBone
	}

	public class Reagent
	{
		private static readonly Type[] m_Types = {
				typeof( BlackPearl ),
				typeof( Bloodmoss ),
				typeof( Garlic ),
				typeof( Ginseng ),
				typeof( MandrakeRoot ),
				typeof( Nightshade ),
				typeof( SulfurousAsh ),
				typeof( SpidersSilk ),
				typeof( BatWing ),
				typeof( GraveDust ),
				typeof( DaemonBlood ),
				typeof( NoxCrystal ),
				typeof( PigIron ),
				typeof( Bone ),
				typeof( FertileDirt ),
				typeof( DragonsBlood ),
				typeof( DaemonBone )
			};

		public static Type[] Types
		{
			get { return m_Types; }
		}

		public static Type BlackPearl
		{
			get { return m_Types[0]; }
			set { m_Types[0] = value; }
		}

		public static Type Bloodmoss
		{
			get { return m_Types[1]; }
			set { m_Types[1] = value; }
		}

		public static Type Garlic
		{
			get { return m_Types[2]; }
			set { m_Types[2] = value; }
		}

		public static Type Ginseng
		{
			get { return m_Types[3]; }
			set { m_Types[3] = value; }
		}

		public static Type MandrakeRoot
		{
			get { return m_Types[4]; }
			set { m_Types[4] = value; }
		}

		public static Type Nightshade
		{
			get { return m_Types[5]; }
			set { m_Types[5] = value; }
		}

		public static Type SulfurousAsh
		{
			get { return m_Types[6]; }
			set { m_Types[6] = value; }
		}

		public static Type SpidersSilk
		{
			get { return m_Types[7]; }
			set { m_Types[7] = value; }
		}

		public static Type BatWing
		{
			get { return m_Types[8]; }
			set { m_Types[8] = value; }
		}

		public static Type GraveDust
		{
			get { return m_Types[9]; }
			set { m_Types[9] = value; }
		}

		public static Type DaemonBlood
		{
			get { return m_Types[10]; }
			set { m_Types[10] = value; }
		}

		public static Type NoxCrystal
		{
			get { return m_Types[11]; }
			set { m_Types[11] = value; }
		}

		public static Type PigIron
		{
			get { return m_Types[12]; }
			set { m_Types[12] = value; }
		}

		public static Type Bone
		{
			get { return m_Types[13]; }
			set { m_Types[13] = value; }
		}

		public static Type FertileDirt
		{
			get { return m_Types[14]; }
			set { m_Types[14] = value; }
		}

		public static Type DragonsBlood
		{
			get { return m_Types[15]; }
			set { m_Types[15] = value; }
		}

		public static Type DaemonBone
		{
			get { return m_Types[16]; }
			set { m_Types[16] = value; }
		}

		public static int GetRegLocalization(Reg reg)
		{
			int loc = 0;

			switch (reg)
			{
				case Reg.BatWing: loc = 1023960; break;
				case Reg.GraveDust: loc = 1023983; break;
				case Reg.DaemonBlood: loc = 1023965; break;
				case Reg.NoxCrystal: loc = 1023982; break;
				case Reg.PigIron: loc = 1023978; break;
				case Reg.Bone: loc = 1023966; break;
				case Reg.DragonBlood: loc = 1023970; break;
				case Reg.FertileDirt: loc = 1023969; break;
				case Reg.DaemonBone: loc = 1023968; break;
			}

			if (loc == 0)
				loc = 1044353 + (int)reg;

			return loc;
		}
	}
}
