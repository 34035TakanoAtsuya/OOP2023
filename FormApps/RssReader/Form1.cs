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
    public partial class Form1 : Form {
        //管理データ保存用
        List<ItemData> ItemDatas = new List<ItemData>();
        public Form1() {
            InitializeComponent();
        }

        Dictionary<string, string> DictFav = new Dictionary<string, string>();

        class FavoriteRegistration {
            public string Name { get; set; }
            public string URL { get; set; }

            public FavoriteRegistration(string Name, string URL) {
                this.Name = Name;
                this.URL = URL;
            }
            public override string ToString() {
                return Name;
            }
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

        private void rbRss2_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/jomo/all.xml";
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

        private void rbRss3_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/gamespav/all.xml";
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

        private void rbRss4_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/media/anmanmv/all.xml";
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

        private void btFav_Click(object sender, EventArgs e) {
            FavoriteRegistration registration = new FavoriteRegistration(tbFavName.Text, tbUrl.Text);

            if (DictFav.ContainsKey(tbUrl.Text) || DictFav.ContainsValue(tbUrl.Text)) {
                lbError.Text = "重複エラー";
            } else {
                lbError.Text = " ";
                DictFav.Add(tbFavName.Text, tbUrl.Text);
                cbFavName.Items.Add(registration);
                tbUrl.Clear();
                tbFavName.Clear();
            }
        }

        private void cbFavName_SelectedIndexChanged(object sender, EventArgs e) {
            FavoriteRegistration favorite = (FavoriteRegistration)cbFavName.SelectedItem;
            tbUrl.Text = favorite.URL.ToString();
        }

        public void RadioButton(string urls) {

            try {
                lbRssTitle.Items.Clear();
                using (var wc = new WebClient()) {

                    var url = wc.OpenRead(urls);
                    XDocument xdoc = XDocument.Load(url);
                    ItemDatas = xdoc.Root.Descendants("item")
                                          .Select(x => new ItemData {
                                              Title = (string)x.Element("title"),
                                              Link = (string)x.Element("link"),
                                          }).ToList();

                    foreach (var node in ItemDatas) {
                        lbRssTitle.Items.Add(node.Title);

                    }
                }
            }
            catch { }
        }

        private void btClear_Click(object sender, EventArgs e) {
            tbUrl.Clear();
            lbRssTitle.Items.Clear();
        }
    }
}
