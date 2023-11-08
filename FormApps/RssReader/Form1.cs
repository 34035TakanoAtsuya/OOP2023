using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class btFavorite : Form {
        //管理データ保存用
        List<ItemData> ItemDatas = new List<ItemData>();
        public btFavorite() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "")
                return;

            lbRssTitle.Items.Clear();   //リストボックスクリア

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item").Select(x => new ItemData {
                            Title = (string)x.Element("title"),
                            Link = (string)x.Element("link")
                          }).ToList();

                foreach (var node in ItemDatas) {
                    lbRssTitle.Items.Add(node.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            var wb = lbRssTitle.SelectedIndex;
            wbBrowser.Navigate(ItemDatas[wb].Link);
        }

        private void btBack_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btForward_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void btRefresh_Click(object sender, EventArgs e) {
            wbBrowser.Refresh();
        }

        private void rbRss1_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/gtv/all.xml";
        }

        private void rbRss2_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/jomo/all.xml";
        }

        private void rbRss3_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/gamespav/all.xml";
        }

        private void rbRss4_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/anmanmv/all.xml";
        }
    }
}
