using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SODScreenScrap
{
	public class Configuration
	{
		public string QWeb { get { return ConfigurationManager.AppSettings["QWeb"]; } }
		public string QWrath { get { return ConfigurationManager.AppSettings["QWrath"]; } }
		public string QAeon { get { return ConfigurationManager.AppSettings["QAeon"]; } }
		public string QFury { get { return ConfigurationManager.AppSettings["QFury"]; } }
		public string QRage { get { return ConfigurationManager.AppSettings["QRage"]; } }
		public string QChaos { get { return ConfigurationManager.AppSettings["QChaos"]; } }
		public string QSaber { get { return ConfigurationManager.AppSettings["QSaber"]; } }
		public string QSithInc { get { return ConfigurationManager.AppSettings["QSithInc"]; } }
		public string QRise { get { return ConfigurationManager.AppSettings["QRise"]; } }
		public string QMyth { get { return ConfigurationManager.AppSettings["QMyth"]; } }
		public string QNexus { get { return ConfigurationManager.AppSettings["QNexus"]; } }
		public string QTriad { get { return ConfigurationManager.AppSettings["QTriad"]; } }
		public string QShadow { get { return ConfigurationManager.AppSettings["QShadow"]; } }

	}
}
