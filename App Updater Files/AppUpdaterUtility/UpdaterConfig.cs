using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUpdater {
	public static class UpdaterConfig {
		public static UpdaterConfigInfo Parse(string text) {
			UpdaterConfigInfo info = new UpdaterConfigInfo();

			string[] lines = text.Split('\n');
			for (int i = 0; i < lines.Length; i++) {
				if (lines[i][0].Equals("#")) {
					continue;
				}

				string[] elements = lines[i].Split(new[] { '=' }, 2);
				info.values.Add(elements[0].Trim(), elements[1].Split('#')[0].Trim());
			}

			return info;
		}
	}

	public class UpdaterConfigInfo {
		public Dictionary<string, string> values;

		public UpdaterConfigInfo(Dictionary<string, string> values = null) {
			if (values == null) {
				this.values = new Dictionary<string, string>();
			}else {
				this.values = values;
			}
		}
	}
}
