#nullable disable
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EngApp.UI
{
    public partial class IrregularVerbsForm : Form
    {
        private List<IrregularVerb> _allVerbs;
        private DataTable _verbTable;

        public IrregularVerbsForm()
        {
            InitializeComponent();
            LoadIrregularVerbs();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void LoadIrregularVerbs()
        {
            // Hardcoded seed data - yaygın düzensiz fiiller
            _allVerbs = new List<IrregularVerb>
            {
                new IrregularVerb("be", "was/were", "been"),
                new IrregularVerb("beat", "beat", "beaten"),
                new IrregularVerb("become", "became", "become"),
                new IrregularVerb("begin", "began", "begun"),
                new IrregularVerb("bend", "bent", "bent"),
                new IrregularVerb("bet", "bet", "bet"),
                new IrregularVerb("bite", "bit", "bitten"),
                new IrregularVerb("blow", "blew", "blown"),
                new IrregularVerb("break", "broke", "broken"),
                new IrregularVerb("bring", "brought", "brought"),
                new IrregularVerb("build", "built", "built"),
                new IrregularVerb("buy", "bought", "bought"),
                new IrregularVerb("catch", "caught", "caught"),
                new IrregularVerb("choose", "chose", "chosen"),
                new IrregularVerb("come", "came", "come"),
                new IrregularVerb("cost", "cost", "cost"),
                new IrregularVerb("cut", "cut", "cut"),
                new IrregularVerb("deal", "dealt", "dealt"),
                new IrregularVerb("dig", "dug", "dug"),
                new IrregularVerb("do", "did", "done"),
                new IrregularVerb("draw", "drew", "drawn"),
                new IrregularVerb("dream", "dreamt/dreamed", "dreamt/dreamed"),
                new IrregularVerb("drink", "drank", "drunk"),
                new IrregularVerb("drive", "drove", "driven"),
                new IrregularVerb("eat", "ate", "eaten"),
                new IrregularVerb("fall", "fell", "fallen"),
                new IrregularVerb("feed", "fed", "fed"),
                new IrregularVerb("feel", "felt", "felt"),
                new IrregularVerb("fight", "fought", "fought"),
                new IrregularVerb("find", "found", "found"),
                new IrregularVerb("fly", "flew", "flown"),
                new IrregularVerb("forget", "forgot", "forgotten"),
                new IrregularVerb("forgive", "forgave", "forgiven"),
                new IrregularVerb("freeze", "froze", "frozen"),
                new IrregularVerb("get", "got", "got/gotten"),
                new IrregularVerb("give", "gave", "given"),
                new IrregularVerb("go", "went", "gone"),
                new IrregularVerb("grow", "grew", "grown"),
                new IrregularVerb("hang", "hung", "hung"),
                new IrregularVerb("have", "had", "had"),
                new IrregularVerb("hear", "heard", "heard"),
                new IrregularVerb("hide", "hid", "hidden"),
                new IrregularVerb("hit", "hit", "hit"),
                new IrregularVerb("hold", "held", "held"),
                new IrregularVerb("hurt", "hurt", "hurt"),
                new IrregularVerb("keep", "kept", "kept"),
                new IrregularVerb("know", "knew", "known"),
                new IrregularVerb("lay", "laid", "laid"),
                new IrregularVerb("lead", "led", "led"),
                new IrregularVerb("leave", "left", "left"),
                new IrregularVerb("lend", "lent", "lent"),
                new IrregularVerb("let", "let", "let"),
                new IrregularVerb("lie", "lay", "lain"),
                new IrregularVerb("lose", "lost", "lost"),
                new IrregularVerb("make", "made", "made"),
                new IrregularVerb("mean", "meant", "meant"),
                new IrregularVerb("meet", "met", "met"),
                new IrregularVerb("pay", "paid", "paid"),
                new IrregularVerb("put", "put", "put"),
                new IrregularVerb("read", "read", "read"),
                new IrregularVerb("ride", "rode", "ridden"),
                new IrregularVerb("ring", "rang", "rung"),
                new IrregularVerb("rise", "rose", "risen"),
                new IrregularVerb("run", "ran", "run"),
                new IrregularVerb("say", "said", "said"),
                new IrregularVerb("see", "saw", "seen"),
                new IrregularVerb("sell", "sold", "sold"),
                new IrregularVerb("send", "sent", "sent"),
                new IrregularVerb("set", "set", "set"),
                new IrregularVerb("shake", "shook", "shaken"),
                new IrregularVerb("shine", "shone", "shone"),
                new IrregularVerb("shoot", "shot", "shot"),
                new IrregularVerb("show", "showed", "shown"),
                new IrregularVerb("shut", "shut", "shut"),
                new IrregularVerb("sing", "sang", "sung"),
                new IrregularVerb("sink", "sank", "sunk"),
                new IrregularVerb("sit", "sat", "sat"),
                new IrregularVerb("sleep", "slept", "slept"),
                new IrregularVerb("speak", "spoke", "spoken"),
                new IrregularVerb("spend", "spent", "spent"),
                new IrregularVerb("stand", "stood", "stood"),
                new IrregularVerb("steal", "stole", "stolen"),
                new IrregularVerb("stick", "stuck", "stuck"),
                new IrregularVerb("strike", "struck", "struck"),
                new IrregularVerb("swear", "swore", "sworn"),
                new IrregularVerb("sweep", "swept", "swept"),
                new IrregularVerb("swim", "swam", "swum"),
                new IrregularVerb("swing", "swung", "swung"),
                new IrregularVerb("take", "took", "taken"),
                new IrregularVerb("teach", "taught", "taught"),
                new IrregularVerb("tear", "tore", "torn"),
                new IrregularVerb("tell", "told", "told"),
                new IrregularVerb("think", "thought", "thought"),
                new IrregularVerb("throw", "threw", "thrown"),
                new IrregularVerb("understand", "understood", "understood"),
                new IrregularVerb("wake", "woke", "woken"),
                new IrregularVerb("wear", "wore", "worn"),
                new IrregularVerb("win", "won", "won"),
                new IrregularVerb("write", "wrote", "written")
            };
        }

        private void SetupDataGridView()
        {
            // DataGridView ayarları
            dgvVerbs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVerbs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVerbs.MultiSelect = false;
            dgvVerbs.ReadOnly = true;
            dgvVerbs.AllowUserToAddRows = false;
            dgvVerbs.AllowUserToDeleteRows = false;
            dgvVerbs.RowHeadersVisible = false;
            dgvVerbs.BackgroundColor = System.Drawing.Color.White;
            dgvVerbs.BorderStyle = BorderStyle.None;
            dgvVerbs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVerbs.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 255);
            dgvVerbs.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            dgvVerbs.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            dgvVerbs.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(32, 33, 36);
            dgvVerbs.DefaultCellStyle.Padding = new Padding(8);
            dgvVerbs.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dgvVerbs.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            dgvVerbs.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(95, 99, 104);
            dgvVerbs.ColumnHeadersHeight = 48;
            dgvVerbs.RowTemplate.Height = 48;
        }

        private void PopulateDataGridView()
        {
            // DataTable oluştur
            _verbTable = new DataTable();
            _verbTable.Columns.Add("Base Form", typeof(string));
            _verbTable.Columns.Add("Past Simple", typeof(string));
            _verbTable.Columns.Add("Past Participle", typeof(string));

            // Verileri ekle
            foreach (var verb in _allVerbs)
            {
                _verbTable.Rows.Add(verb.BaseForm, verb.PastSimple, verb.PastParticiple);
            }

            dgvVerbs.DataSource = _verbTable;
            
            // Toplam sayıyı göster
            lblTotalVerbs.Text = $"Total: {_allVerbs.Count} irregular verbs";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Arama boşsa tüm verileri göster
                dgvVerbs.DataSource = _verbTable;
                lblTotalVerbs.Text = $"Total: {_allVerbs.Count} irregular verbs";
            }
            else
            {
                // Arama yap - herhangi bir sütunda eşleşme ara
                var filteredVerbs = _allVerbs.Where(v =>
                    v.BaseForm.ToLower().Contains(searchText) ||
                    v.PastSimple.ToLower().Contains(searchText) ||
                    v.PastParticiple.ToLower().Contains(searchText)
                ).ToList();

                // Filtrelenmiş DataTable oluştur
                var filteredTable = new DataTable();
                filteredTable.Columns.Add("Base Form", typeof(string));
                filteredTable.Columns.Add("Past Simple", typeof(string));
                filteredTable.Columns.Add("Past Participle", typeof(string));

                foreach (var verb in filteredVerbs)
                {
                    filteredTable.Rows.Add(verb.BaseForm, verb.PastSimple, verb.PastParticiple);
                }

                dgvVerbs.DataSource = filteredTable;
                lblTotalVerbs.Text = $"Showing: {filteredVerbs.Count} of {_allVerbs.Count} verbs";
            }
        }
    }

    // Düzensiz fiil için basit model sınıfı
    public class IrregularVerb
    {
        public string BaseForm { get; set; }
        public string PastSimple { get; set; }
        public string PastParticiple { get; set; }

        public IrregularVerb(string baseForm, string pastSimple, string pastParticiple)
        {
            BaseForm = baseForm;
            PastSimple = pastSimple;
            PastParticiple = pastParticiple;
        }
    }
}
