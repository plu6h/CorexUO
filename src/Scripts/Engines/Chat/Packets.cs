using Server.Network;

namespace Server.Engines.Chat
{
	public sealed class ChatMessagePacket : Packet
	{
		public ChatMessagePacket(Mobile who, int number, string param1, string param2) : base(0xB2)
		{
			param1 ??= string.Empty;

			param2 ??= string.Empty;

			EnsureCapacity(13 + ((param1.Length + param2.Length) * 2));

			m_Stream.Write((ushort)(number - 20));

			if (who != null)
				m_Stream.WriteAsciiFixed(who.Language, 4);
			else
				m_Stream.Write(0);

			m_Stream.WriteBigUniNull(param1);
			m_Stream.WriteBigUniNull(param2);
		}
	}
}
