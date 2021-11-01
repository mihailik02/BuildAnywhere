using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace BuildAnywhere
{
	public class Hotkey
	{
		private class Press : EventArgs
		{
			public KeyCode Key;

			public Press(KeyCode Key)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				this.Key = Key;
			}
		}

		public class KeyState
		{
			public KeyCode Key;

			public bool State;

			public KeyState(KeyCode Key)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				this.Key = Key;
				State = false;
			}

			public override bool Equals(object obj)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_001b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				return (KeyCode?)Key == (obj as KeyState)?.Key;
			}

			public override int GetHashCode()
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Expected I4, but got Unknown
				return (int)Key;
			}
		}

		public static class Patch_test1
		{
			public static void Prefix(string uscript_name)
			{
				Debug.Log((object)("HELLO WORLD: " + uscript_name));
			}
		}

		public static List<KeyState> Listener = new List<KeyState>();

		public static event EventHandler<KeyCode> Keypress;

		public static void Update()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				if (!MainGame.paused && MainGame.game_started)
				{
					foreach (KeyState item in Listener)
					{
						Debug.Log((object)("[BuildAnywhere] Checking for button: " + item.Key));
						if (Input.GetKey(item.Key))
						{
							Debug.Log((object)"[BuildAnywhere] Button pressed");
						}
						if (Input.GetKey(item.Key) != item.State)
						{
							Debug.Log((object)"[BuildAnywhere] State triggered");
							item.State = !item.State;
							if (!item.State)
							{
								Hotkey.Keypress?.Invoke(null, item.Key);
							}
						}
					}
				}
				else
				{
					foreach (KeyState item2 in Listener)
					{
						item2.State = false;
					}
				}
				Thread.Sleep(50);
			}
		}
	}
}
