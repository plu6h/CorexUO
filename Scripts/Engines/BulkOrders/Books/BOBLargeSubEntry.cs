using System;

namespace Server.Engines.BulkOrders
{
	public class BOBLargeSubEntry
	{
		private readonly Type m_ItemType;
		private readonly int m_AmountCur;
		private readonly int m_Number;
		private readonly int m_Graphic;

		public Type ItemType => m_ItemType;
		public int AmountCur => m_AmountCur;
		public int Number => m_Number;
		public int Graphic => m_Graphic;

		public BOBLargeSubEntry(LargeBulkEntry lbe)
		{
			m_ItemType = lbe.Details.Type;
			m_AmountCur = lbe.Amount;
			m_Number = lbe.Details.Number;
			m_Graphic = lbe.Details.Graphic;
		}

		public BOBLargeSubEntry(GenericReader reader)
		{
			int version = reader.ReadEncodedInt();

			switch (version)
			{
				case 0:
					{
						string type = reader.ReadString();

						if (type != null)
							m_ItemType = Assembler.FindTypeByFullName(type);

						m_AmountCur = reader.ReadEncodedInt();
						m_Number = reader.ReadEncodedInt();
						m_Graphic = reader.ReadEncodedInt();

						break;
					}
			}
		}

		public void Serialize(GenericWriter writer)
		{
			writer.WriteEncodedInt(0); // version

			writer.Write(m_ItemType?.FullName);

			writer.WriteEncodedInt(m_AmountCur);
			writer.WriteEncodedInt(m_Number);
			writer.WriteEncodedInt(m_Graphic);
		}
	}
}
