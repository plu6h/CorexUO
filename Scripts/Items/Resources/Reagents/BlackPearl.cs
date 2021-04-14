namespace Server.Items
{
	public class BlackPearl : BaseReagent, ICommodity
	{
		int ICommodity.DescriptionNumber => LabelNumber;
		bool ICommodity.IsDeedable => true;

		[Constructable]
		public BlackPearl() : this(1)
		{
		}

		[Constructable]
		public BlackPearl(int amount) : base(0xF7A, amount)
		{
		}

		public BlackPearl(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write(0); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			_ = reader.ReadInt();
		}
	}
}
