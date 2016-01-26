using Api;
using Controls.Alert;
using Controls.Button;
using Controls.Container;
using Controls.Container.Extentions;
using Controls.Editors.DateSelector;
using Controls.Editors.Selector;
using Controls.FileColumnButton;
using Controls.Grid;
using Controls.Grid.Filter;
using Controls.Grid.Upload;
using Controls.ImageUploader;
using Controls.Input.PXNumberEdit;
using Controls.Input.PXTextEdit;
using Controls.Label;
using Controls.NoteColumnButton;
using Controls.PxControlCollection;
using Controls.ToolBarButton;
using Core;
using Core.ApiConnection;
using Core.Core.Browser;
using System;


namespace Core {
    
    
    public class RP301000_RentalManagement : Wrapper {
        
        public Note NotePanel;
        
        public SmartPanel_AttachFile FilesUploadDialog;
        
        public PxToolBar ToolBar;
        
        private c_items_form items_form;
        
        private c_firstselect_formactions firstselect_formactions;
        
        private c_vieweleminfo_formeleminfo vieweleminfo_formeleminfo;
        
        private c_filterworkingproject_formnewproject filterworkingproject_formnewproject;
        
        private c_filterworkingproject_formselectproject filterworkingproject_formselectproject;
        
        private c_rentals_lv0 rentals_lv0;
        
        private c_rentals_grid rentals_grid;
        
        public RP301000_RentalManagement() {
            ScreenId = "RP301000";
            ScreenUrl = "/Pages/RP/RP301000.aspx";
            NotePanel = new Note("ctl00_usrCaption_tlbDataView");
            FilesUploadDialog = new SmartPanel_AttachFile("ctl00_usrCaption_tlbDataView");
            ToolBar = new PxToolBar();
            items_form = new c_items_form("ctl00_phF_form", "Items_form", null, null, "RP301000");
            firstselect_formactions = new c_firstselect_formactions("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", "FirstSelect_FormActions", null, null, "RP301000");
            vieweleminfo_formeleminfo = new c_vieweleminfo_formeleminfo("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", "ViewElemInfo_FormElemInfo", null, null, "RP301000");
            filterworkingproject_formnewproject = new c_filterworkingproject_formnewproject("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", "FilterWorkingProject_FormNewProject", null, null, "RP301000");
            filterworkingproject_formselectproject = new c_filterworkingproject_formselectproject("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", "FilterWorkingProject_FormSelectProject", null, null, "RP301000");
            rentals_lv0 = new c_rentals_lv0("ctl00_phG_grid_lv0", "Rentals_lv0", null, null, "RP301000");
            rentals_grid = new c_rentals_grid(c_rentals_grid.GridLocator, c_rentals_grid.GridName);
        }
        
        protected virtual c_items_form Items_form {
            get {
                return items_form;
            }
            set {
                items_form = value;
            }
        }
        
        protected virtual c_firstselect_formactions FirstSelect_FormActions {
            get {
                return firstselect_formactions;
            }
            set {
                firstselect_formactions = value;
            }
        }
        
        protected virtual c_vieweleminfo_formeleminfo ViewElemInfo_FormElemInfo {
            get {
                return vieweleminfo_formeleminfo;
            }
            set {
                vieweleminfo_formeleminfo = value;
            }
        }
        
        protected virtual c_filterworkingproject_formnewproject FilterWorkingProject_FormNewProject {
            get {
                return filterworkingproject_formnewproject;
            }
            set {
                filterworkingproject_formnewproject = value;
            }
        }
        
        protected virtual c_filterworkingproject_formselectproject FilterWorkingProject_FormSelectProject {
            get {
                return filterworkingproject_formselectproject;
            }
            set {
                filterworkingproject_formselectproject = value;
            }
        }
        
        protected virtual c_rentals_lv0 Rentals_lv0 {
            get {
                return rentals_lv0;
            }
            set {
                rentals_lv0 = value;
            }
        }
        
        protected virtual c_rentals_grid Rentals_grid {
            get {
                return rentals_grid;
            }
            set {
                rentals_grid = value;
            }
        }
        
        public virtual RP301000_RentalManagement ReadOne(Gate gate, string RentalItemCD) {
            new BiObject<RP301000_RentalManagement>(gate).ReadOne(this, RentalItemCD);
            return this;
        }
        
        public virtual RP301000_RentalManagement ReadOne(string RentalItemCD) {
            return this.ReadOne(Source, RentalItemCD);
        }
        
        public virtual void SyncTOC() {
            ToolBar.SyncTOC.Click();
        }
        
        public virtual void Favorites() {
            ToolBar.Favorites.Click();
        }
        
        public virtual void ClearFilter() {
            ToolBar.ClearFilter.Click();
        }
        
        public virtual void Note() {
            ToolBar.Note.Click();
        }
        
        public virtual void FilesMenuShow() {
            ToolBar.FilesMenuShow.Click();
        }
        
        public virtual void Custom() {
            ToolBar.Custom.Click();
        }
        
        public virtual void ActionSelectWorkingProject() {
            ToolBar.ActionSelectWorkingProject.Click();
        }
        
        public virtual void InspectElementCtrlAtlClick() {
            ToolBar.InspectElementCtrlAtlClick.Click();
        }
        
        public virtual void MenuEditProj() {
            ToolBar.MenuEditProj.Click();
        }
        
        public virtual void ManageCustomizations() {
            ToolBar.ManageCustomizations.Click();
        }
        
        public virtual void ActionNavigateAspx() {
            ToolBar.ActionNavigateAspx.Click();
        }
        
        public virtual void ActionCreateNewProject() {
            ToolBar.ActionCreateNewProject.Click();
        }
        
        public virtual void MenuLayoutEditor() {
            ToolBar.MenuLayoutEditor.Click();
        }
        
        public virtual void MenuEditProj1() {
            ToolBar.MenuEditProj1.Click();
        }
        
        public virtual void MenuDacEditor() {
            ToolBar.MenuDacEditor.Click();
        }
        
        public virtual void MenuGraphEditor() {
            ToolBar.MenuGraphEditor.Click();
        }
        
        public virtual void MenuLayoutSrc() {
            ToolBar.MenuLayoutSrc.Click();
        }
        
        public virtual void MenuGraphSrc() {
            ToolBar.MenuGraphSrc.Click();
        }
        
        public virtual void MenuDacSrc() {
            ToolBar.MenuDacSrc.Click();
        }
        
        public virtual void MenuLayoutVS() {
            ToolBar.MenuLayoutVS.Click();
        }
        
        public virtual void MenuDacVS() {
            ToolBar.MenuDacVS.Click();
        }
        
        public virtual void MenuGraphVS() {
            ToolBar.MenuGraphVS.Click();
        }
        
        public virtual void ActionSelectWorkingProject1() {
            ToolBar.ActionSelectWorkingProject1.Click();
        }
        
        public virtual void LongRun() {
            ToolBar.LongRun.Click();
        }
        
        public virtual void ElapsedTime() {
            ToolBar.ElapsedTime.Click();
        }
        
        public virtual void KeyBtnRefresh() {
            ToolBar.KeyBtnRefresh.Click();
        }
        
        public virtual void Help() {
            ToolBar.Help.Click();
        }
        
        public virtual void Save() {
            if (ToolBar.Save.IsEnabled()) {
                ToolBar.Save.Click();
            }
        }
        
        public virtual void Cancel() {
            ToolBar.Cancel.Click();
        }
        
        public virtual void Insert() {
            ToolBar.Insert.Click();
        }
        
        public virtual void Delete() {
            ToolBar.Delete.Click();
        }
        
        public virtual void Clipboard() {
            ToolBar.Clipboard.Click();
        }
        
        public virtual void CopyDocument() {
            ToolBar.CopyDocument.Click();
        }
        
        public virtual void PasteDocument() {
            ToolBar.PasteDocument.Click();
        }
        
        public virtual void SaveTemplate() {
            ToolBar.SaveTemplate.Click();
        }
        
        public virtual void First() {
            ToolBar.First.Click();
        }
        
        public virtual void Previous() {
            ToolBar.Previous.Click();
        }
        
        public virtual void Next() {
            ToolBar.Next.Click();
        }
        
        public virtual void Last() {
            ToolBar.Last.Click();
        }
        
        public class PxToolBar : PxControlCollection {
            
			public ToolBarButton SyncTOC {get; private set; }
			public ToolBarButton Favorites {get; private set; }
			public ToolBarButton ClearFilter {get; private set; }
			public ToolBarButton Note {get; private set; }
			public ToolBarButton FilesMenuShow {get; private set; }
			public ToolBarButton Custom {get; private set; }
			public ToolBarButton ActionSelectWorkingProject {get; private set; }
			public ToolBarButton InspectElementCtrlAtlClick {get; private set; }
			public ToolBarButton MenuEditProj {get; private set; }
			public ToolBarButton ManageCustomizations {get; private set; }
			public ToolBarButton ActionNavigateAspx {get; private set; }
			public ToolBarButton ActionCreateNewProject {get; private set; }
			public ToolBarButton MenuLayoutEditor {get; private set; }
			public ToolBarButton MenuEditProj1 {get; private set; }
			public ToolBarButton MenuDacEditor {get; private set; }
			public ToolBarButton MenuGraphEditor {get; private set; }
			public ToolBarButton MenuLayoutSrc {get; private set; }
			public ToolBarButton MenuGraphSrc {get; private set; }
			public ToolBarButton MenuDacSrc {get; private set; }
			public ToolBarButton MenuLayoutVS {get; private set; }
			public ToolBarButton MenuDacVS {get; private set; }
			public ToolBarButton MenuGraphVS {get; private set; }
			public ToolBarButton ActionSelectWorkingProject1 {get; private set; }
			public ToolBarButton LongRun {get; private set; }
			public ToolBarButton ElapsedTime {get; private set; }
			public ToolBarButton KeyBtnRefresh {get; private set; }
			public ToolBarButton Help {get; private set; }
			public ToolBarButton Save {get; private set; }
			public ToolBarButton Cancel {get; private set; }
			public ToolBarButton Insert {get; private set; }
			public ToolBarButton Delete {get; private set; }
			public ToolBarButton Clipboard {get; private set; }
			public ToolBarButton CopyDocument {get; private set; }
			public ToolBarButton PasteDocument {get; private set; }
			public ToolBarButton SaveTemplate {get; private set; }
			public ToolBarButton First {get; private set; }
			public ToolBarButton Previous {get; private set; }
			public ToolBarButton Next {get; private set; }
			public ToolBarButton Last {get; private set; }
            
            public PxToolBar() {
                SyncTOC = new ToolBarButton("css=div[data-cmd='syncTOC']", "Sync Navigation Pane", "", null, "RP301000");
                Favorites = new ToolBarButton("css=div[data-cmd='favorites']", "Add to Favorites", "", null, "RP301000");
                ClearFilter = new ToolBarButton("css=div[data-cmd='clearFilter']", "Clear Active Filter", "", null, "RP301000");
                Note = new ToolBarButton("css=div[data-cmd='NoteShow']", "Add Note", "", null, "RP301000");
                FilesMenuShow = new ToolBarButton("css=div[data-cmd='FilesMenuShow']", "Files", "", null, "RP301000");
                Custom = new ToolBarButton("css=div[data-cmd='Custom']", "Customization", "", null, "RP301000");
                ActionSelectWorkingProject = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd='ActionSelectWorkingProject']", "Select Project...", "", null, "RP301000", Custom);
                InspectElementCtrlAtlClick = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem div:contains('Inspect Element (Ctrl+Atl+Click)')", "Inspect Element (Ctrl+Atl+Click)", "", null, "RP301000", Custom);
                MenuEditProj = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li[data-cmd='menuEditProj']", "Edit Project...", "", null, "RP301000", Custom);
                ManageCustomizations = new ToolBarButton("css=div#ctl00_usrCaption_CustomizationDialogs_PXToolBar1_menuCustom li.menuItem div:contains('Manage Customizations...')", "Manage Customizations...", "", null, "RP301000", Custom);
                ActionNavigateAspx = new ToolBarButton("css=div[data-cmd='actionNavigateAspx']", "actionNavigateAspx", "", null, "RP301000");
                ActionCreateNewProject = new ToolBarButton("css=div[data-cmd='actionCreateNewProject']", "actionCreateNewProject", "", null, "RP301000");
                MenuLayoutEditor = new ToolBarButton("css=div[data-cmd='menuLayoutEditor']", "Customize", "", null, "RP301000");
                MenuEditProj1 = new ToolBarButton("css=div[data-cmd='menuEditProj']", "Edit Project ...", "", null, "RP301000");
                MenuDacEditor = new ToolBarButton("css=div[data-cmd='menuDacEditor']", "menuDacEditor", "", null, "RP301000");
                MenuGraphEditor = new ToolBarButton("css=div[data-cmd='menuGraphEditor']", "menuGraphEditor", "", null, "RP301000");
                MenuLayoutSrc = new ToolBarButton("css=div[data-cmd='menuLayoutSrc']", "menuLayoutSrc", "", null, "RP301000");
                MenuGraphSrc = new ToolBarButton("css=div[data-cmd='menuGraphSrc']", "menuGraphSrc", "", null, "RP301000");
                MenuDacSrc = new ToolBarButton("css=div[data-cmd='menuDacSrc']", "menuDacSrc", "", null, "RP301000");
                MenuLayoutVS = new ToolBarButton("css=div[data-cmd='menuLayoutVS']", "menuLayoutVS", "", null, "RP301000");
                MenuDacVS = new ToolBarButton("css=div[data-cmd='menuDacVS']", "menuDacVS", "", null, "RP301000");
                MenuGraphVS = new ToolBarButton("css=div[data-cmd='menuGraphVS']", "menuGraphVS", "", null, "RP301000");
                ActionSelectWorkingProject1 = new ToolBarButton("css=div[data-cmd='actionSelectWorkingProject']", "actionSelectWorkingProject", "", null, "RP301000");
                LongRun = new ToolBarButton("css=div[data-cmd='LongRun']", "Nothing in progress", "", null, "RP301000");
                ElapsedTime = new ToolBarButton("css=div[data-cmd='ElapsedTime']", "Elapsed time", "", null, "RP301000");
                KeyBtnRefresh = new ToolBarButton("css=div[data-cmd='keyBtnRefresh']", "Click to refresh page.", "", null, "RP301000");
                Help = new ToolBarButton("css=div[data-cmd='help']", "View Help", "", null, "RP301000");
                Save = new ToolBarButton("css=div[data-cmd='Save']", "Save (Ctrl+S)", "", null, "RP301000");
                Cancel = new ToolBarButton("css=div[data-cmd='Cancel']", "Cancel (Esc)", "", null, "RP301000");
                Cancel.ConfirmAction = Alert.AlertToException;
                Insert = new ToolBarButton("css=div[data-cmd='Insert']", "Add New Record (Ctrl+Ins)", "", null, "RP301000");
                Delete = new ToolBarButton("css=div[data-cmd='Delete']", "Delete (Ctrl+Del)", "", null, "RP301000");
                Delete.ConfirmAction = Alert.AlertToException;
                Clipboard = new ToolBarButton("css=li>div.toolsBtn[tooltip='Clipboard']", "Clipboard", "", null, "RP301000");
                CopyDocument = new ToolBarButton("css=li[data-cmd='CopyPaste@CopyDocument']", "Copy", "", null, "RP301000", Clipboard);
                PasteDocument = new ToolBarButton("css=li[data-cmd='CopyPaste@PasteDocument']", "Paste", "", null, "RP301000", Clipboard);
                SaveTemplate = new ToolBarButton("css=li[data-cmd='CopyPaste@SaveTemplate']", "Save as Template...", "", null, "RP301000", Clipboard);
                First = new ToolBarButton("css=div[data-cmd='First']", "Go to First Record", "", null, "RP301000");
                Previous = new ToolBarButton("css=div[data-cmd='Previous']", "Go to Previous Record (PgUp)", "", null, "RP301000");
                Next = new ToolBarButton("css=div[data-cmd='Next']", "Go to Next Record (PgDn)", "", null, "RP301000");
                Last = new ToolBarButton("css=div[data-cmd='Last']", "Go to Last Record", "", null, "RP301000");
            }
        }
        
        public class c_items_form : Container {
            
			public Selector RentalItemCD {get;set;}
			protected Label RentalItemCDLabel {get;set;}
			public PXTextEdit Description {get;set;}
			protected Label DescriptionLabel {get;set;}
			public PXNumberEdit Cost {get;set;}
			protected Label CostLabel {get;set;}
			public PXTextEdit SerialNumber {get;set;}
			protected Label SerialNumberLabel {get;set;}
			public ImageUploader ImgUploader {get;set;}
            
            public c_items_form(String locator, String name) : 
                    base(locator, name) {
                Initialize();
            }
            
            public c_items_form(String locator, String name, String tabid, int? index, String screenId) : 
                    base(locator, name, tabid, index, screenId) {
                Initialize();
            }
            
            private void Initialize() {
                RentalItemCD = new Selector("ctl00_phF_form_edRentalItemCD", "Rental Item Code", "ctl00_phF_form", null, "RP301000");
                RentalItemCDLabel = new Label(RentalItemCD);
                RentalItemCD.Label = RentalItemCDLabel;
                RentalItemCD.DataField = "RentalItemCD";
                Description = new PXTextEdit("ctl00_phF_form_edDescription", "Description", "ctl00_phF_form", null, "RP301000");
                DescriptionLabel = new Label(Description);
                Description.Label = DescriptionLabel;
                Description.DataField = "Description";
                Cost = new PXNumberEdit("ctl00_phF_form_edCost", "Cost", "ctl00_phF_form", null, "RP301000");
                CostLabel = new Label(Cost);
                Cost.Label = CostLabel;
                Cost.DataField = "Cost";
                SerialNumber = new PXTextEdit("ctl00_phF_form_edSerialNumber", "Serial Number", "ctl00_phF_form", null, "RP301000");
                SerialNumberLabel = new Label(SerialNumber);
                SerialNumber.Label = SerialNumberLabel;
                SerialNumber.DataField = "SerialNumber";
                ImgUploader = new ImageUploader("ctl00_phF_form_imgUploader", "&nbsp", "ctl00_phF_form", null, "RP301000");
                DataMemberName = "Items";
            }
        }
        
        public class c_firstselect_formactions : Container {
            
			public PXTextEdit Key {get;set;}
			protected Label KeyLabel {get;set;}
            
            public c_firstselect_formactions(String locator, String name) : 
                    base(locator, name) {
                Initialize();
            }
            
            public c_firstselect_formactions(String locator, String name, String tabid, int? index, String screenId) : 
                    base(locator, name, tabid, index, screenId) {
                Initialize();
            }
            
            private void Initialize() {
                Key = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions_edKey", "Key", "ctl00_usrCaption_CustomizationDialogs_PXSmartPanel1_FormActions", null, "RP301000");
                KeyLabel = new Label(Key);
                Key.Label = KeyLabel;
                Key.DataField = "Key";
                DataMemberName = "FirstSelect";
            }
        }
        
        public class c_vieweleminfo_formeleminfo : Container {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit AspxControl {get;set;}
			protected Label AspxControlLabel {get;set;}
			public PXTextEdit CacheType {get;set;}
			protected Label CacheTypeLabel {get;set;}
			public PXTextEdit FieldName {get;set;}
			protected Label FieldNameLabel {get;set;}
			public PXTextEdit GraphName {get;set;}
			protected Label GraphNameLabel {get;set;}
            
            public c_vieweleminfo_formeleminfo(String locator, String name) : 
                    base(locator, name) {
                Initialize();
            }
            
            public c_vieweleminfo_formeleminfo(String locator, String name, String tabid, int? index, String screenId) : 
                    base(locator, name, tabid, index, screenId) {
                Initialize();
            }
            
            public virtual void Customize() {
                ActionClick(Buttons.Customize);
            }
            
            public virtual void Actions() {
                ActionClick(Buttons.Actions);
            }
            
            public virtual void Cancel() {
                ActionClick(Buttons.Cancel);
            }
            
            private void Initialize() {
                AspxControl = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_edAspxControl", "Control Type", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", null, "RP301000");
                AspxControlLabel = new Label(AspxControl);
                AspxControl.Label = AspxControlLabel;
                AspxControl.DataField = "AspxControl";
                CacheType = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_CacheType", "Data Class", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", null, "RP301000");
                CacheTypeLabel = new Label(CacheType);
                CacheType.Label = CacheTypeLabel;
                CacheType.DataField = "CacheType";
                FieldName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_FieldName", "Data Field", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", null, "RP301000");
                FieldNameLabel = new Label(FieldName);
                FieldName.Label = FieldNameLabel;
                FieldName.DataField = "FieldName";
                GraphName = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo_GraphName", "Business Logic", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", null, "RP301000");
                GraphNameLabel = new Label(GraphName);
                GraphName.Label = GraphNameLabel;
                GraphName.DataField = "GraphName";
                DataMemberName = "ViewElemInfo";
                Buttons = new PxButtonCollection();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Customize {get; private set; }
			public Button Actions {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    Customize = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton3", "Customize", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", null, "RP301000");
                    Actions = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_ButtonGraphActions", "Actions", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", null, "RP301000");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_PXButton4", "Cancel", "ctl00_usrCaption_CustomizationDialogs_PanelElemInfo_FormElemInfo", null, "RP301000");
                }
            }
        }
        
        public class c_filterworkingproject_formnewproject : Container {
            
            public PxButtonCollection Buttons;
            
			public PXTextEdit NewProject {get;set;}
			protected Label NewProjectLabel {get;set;}
            
            public c_filterworkingproject_formnewproject(String locator, String name) : 
                    base(locator, name) {
                Initialize();
            }
            
            public c_filterworkingproject_formnewproject(String locator, String name, String tabid, int? index, String screenId) : 
                    base(locator, name, tabid, index, screenId) {
                Initialize();
            }
            
            public virtual void Ok() {
                ActionClick(Buttons.Ok);
            }
            
            public virtual void Cancel() {
                ActionClick(Buttons.Cancel);
            }
            
            private void Initialize() {
                NewProject = new PXTextEdit("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject_edNewProject", "Project Name", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", null, "RP301000");
                NewProjectLabel = new Label(NewProject);
                NewProject.Label = NewProjectLabel;
                NewProject.DataField = "NewProject";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
                
                public PxButtonCollection() {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonOk", "OK", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", null, "RP301000");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_DlgNewProject_DlgNewProjectButtonCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_DlgNewProject_FormNewProject", null, "RP301000");
                }
            }
        }
        
        public class c_filterworkingproject_formselectproject : Container {
            
            public PxButtonCollection Buttons;
            
			public Selector Name {get;set;}
			protected Label NameLabel {get;set;}
            
            public c_filterworkingproject_formselectproject(String locator, String name) : 
                    base(locator, name) {
                Initialize();
            }
            
            public c_filterworkingproject_formselectproject(String locator, String name, String tabid, int? index, String screenId) : 
                    base(locator, name, tabid, index, screenId) {
                Initialize();
            }
            
            public virtual void Ok() {
                ActionClick(Buttons.Ok);
            }
            
            public virtual void Cancel() {
                ActionClick(Buttons.Cancel);
            }
            
            public virtual void New() {
                ActionClick(Buttons.New);
            }
            
            private void Initialize() {
                Name = new Selector("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject_edWP", "Project Name", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", null, "RP301000");
                NameLabel = new Label(Name);
                Name.Label = NameLabel;
                Name.DataField = "Name";
                DataMemberName = "FilterWorkingProject";
                Buttons = new PxButtonCollection();
            }
            
            public class PxButtonCollection : PxControlCollection {
                
			public Button Ok {get; private set; }
			public Button Cancel {get; private set; }
			public Button New {get; private set; }
                
                public PxButtonCollection() {
                    Ok = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectOk", "OK", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", null, "RP301000");
                    Cancel = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_SelectProjectCancel", "Cancel", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", null, "RP301000");
                    New = new Button("ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_BtnNewProject", "New...", "ctl00_usrCaption_CustomizationDialogs_WizardSelectProject_FormSelectProject", null, "RP301000");
                }
            }
        }
        
        public class c_rentals_lv0 : Container {
            
			public Selector CustomerID {get;set;}
			protected Label CustomerIDLabel {get;set;}
			public DateSelector StartDate {get;set;}
			protected Label StartDateLabel {get;set;}
			public DateSelector EndDate {get;set;}
			protected Label EndDateLabel {get;set;}
			public Selector Es {get;set;}
            
            public c_rentals_lv0(String locator, String name) : 
                    base(locator, name) {
                Initialize();
            }
            
            public c_rentals_lv0(String locator, String name, String tabid, int? index, String screenId) : 
                    base(locator, name, tabid, index, screenId) {
                Initialize();
            }
            
            private void Initialize() {
                CustomerID = new Selector("ctl00_phG_grid_lv0_edCustomerID", "Customer", "ctl00_phG_grid_lv0", null, "RP301000");
                CustomerIDLabel = new Label(CustomerID);
                CustomerID.Label = CustomerIDLabel;
                CustomerID.DataField = "CustomerID";
                StartDate = new DateSelector("ctl00_phG_grid_lv0_edStartDate", "Start Date", "ctl00_phG_grid_lv0", null, "RP301000");
                StartDateLabel = new Label(StartDate);
                StartDate.Label = StartDateLabel;
                StartDate.DataField = "StartDate";
                EndDate = new DateSelector("ctl00_phG_grid_lv0_edEndDate", "End Date", "ctl00_phG_grid_lv0", null, "RP301000");
                EndDateLabel = new Label(EndDate);
                EndDate.Label = EndDateLabel;
                EndDate.DataField = "EndDate";
                Es = new Selector("ctl00_phG_grid_lv0_es", "Es", "ctl00_phG_grid_lv0", null, "RP301000");
                DataMemberName = "Rentals";
            }
        }
        
        public class c_rentals_grid : Grid<c_rentals_grid.c_grid_row> {
            
            private static String _GridLocator = "ctl00_phG_grid";
            
            private static String _GridName = "Rentals_grid";
            
            private c_grid_filter_ex gridfilter;
            
            public PxToolBar ToolBar;
            
			public c_grid_header ColumnFilters {get; private set;}
			public SmartPanel_AttachFile FilesUploadDialog {get; private set;}
			public Note NotePanel {get; private set;}
            
            public c_rentals_grid(String locator, String name) : 
                    base(locator, name) {
                gridfilter = new c_grid_filter_ex("ctl00_phG_grid_fe_gf", null, null, null, "RP301000");
                ToolBar = new PxToolBar();
                DataMemberName = "Rentals";
                ColumnFilters = new c_grid_header(Row);
                FilesUploadDialog = new SmartPanel_AttachFile(GridLocator);
                NotePanel = new Note(GridLocator);
            }
            
            public static String GridLocator {
                get {
                    return _GridLocator;
                }
                set {
                    _GridLocator = value;
                }
            }
            
            public static String GridName {
                get {
                    return _GridName;
                }
                set {
                    _GridName = value;
                }
            }
            
            public virtual c_grid_filter_ex FilterForm {
                get {
                    c_grid_filter.Lctr = _GridLocator;
                    return gridfilter;
                }
                set {
                    c_grid_filter.Lctr = _GridLocator;
                    gridfilter = value;
                }
            }
            
            public virtual c_grid_filter_ex.c_fields Columns {
                get {
                    return gridfilter.Fields;
                }
            }
            
            public virtual void Refresh() {
                ToolBar.Refresh.Click();
            }
            
            public virtual void New() {
                if (ToolBar.New.IsEnabled()) {
                    ToolBar.New.Click();
                }
            }
            
            public virtual void Delete() {
                ToolBar.Delete.Click();
            }
            
            public virtual void Adjust() {
                ToolBar.Adjust.Click();
            }
            
            public virtual void Export() {
                ToolBar.Export.Click();
            }
            
            public virtual void FilterBar() {
                ToolBar.FilterBar.Click();
            }
            
            public virtual void PageFirst() {
                ToolBar.PageFirst.Click();
            }
            
            public virtual void PagePrev() {
                ToolBar.PagePrev.Click();
            }
            
            public virtual void PageNext() {
                ToolBar.PageNext.Click();
            }
            
            public virtual void PageLast() {
                ToolBar.PageLast.Click();
            }
            
            public class c_grid_filter_ex : c_grid_filter {
                
                private c_fields fields;
                
                public c_grid_filter_ex(String locator) : 
                        base(locator) {
                    fields = new c_fields();
                }
                
                public c_grid_filter_ex(String locator, String name, String tabid, int? index, String screenId) : 
                        base(locator, name, tabid, index, screenId) {
                    fields = new c_fields();
                }
                
                public virtual c_fields Fields {
                    get {
                        return fields;
                    }
                    set {
                        fields = value;
                    }
                }
                
                public class c_fields {
                    
                    public c_rule.c_property Files;
                    
                    public c_rule.c_property Notes;
                    
                    public c_rule.c_property CustomerID;
                    
                    public c_rule.c_property StartDate;
                    
                    public c_rule.c_property EndDate;
                    
                    public c_rule.c_property RentalID;
                    
                    public c_rule.c_property RentalItemCD;
                    
                    public c_fields() {
                        Files = new c_rule.c_property("Files", "Int32", null, 0, "RP301000");
                        Notes = new c_rule.c_property("Notes", "Int32", null, 1, "RP301000");
                        CustomerID = new c_rule.c_property("Customer", "String", "PX.Web.UI.PXSelector", 2, "RP301000");
                        StartDate = new c_rule.c_property("Start Date", "DateTime", "PX.Web.UI.PXDateTimeEdit", 3, "RP301000");
                        EndDate = new c_rule.c_property("End Date", "DateTime", "PX.Web.UI.PXDateTimeEdit", 4, "RP301000");
                        RentalID = new c_rule.c_property("RentalID", "Int32", "PX.Web.UI.PXNumberEdit", 5, "RP301000");
                        RentalItemCD = new c_rule.c_property("Rental Item Code", "String", "PX.Web.UI.PXTextEdit", 6, "RP301000");
                    }
                }
            }
            
            public class PxToolBar : PxControlCollection {
                
			public ToolBarButtonGrid Refresh {get; private set; }
			public ToolBarButtonGrid New {get; private set; }
			public ToolBarButtonGrid Delete {get; private set; }
			public ToolBarButtonGrid Adjust {get; private set; }
			public ToolBarButtonGrid Export {get; private set; }
			public ToolBarButtonGrid FilterBar {get; private set; }
			public ToolBarButtonGrid PageFirst {get; private set; }
			public ToolBarButtonGrid PagePrev {get; private set; }
			public ToolBarButtonGrid PageNext {get; private set; }
			public ToolBarButtonGrid PageLast {get; private set; }
                
                public PxToolBar() {
                    Refresh = new ToolBarButtonGrid("css=div[data-cmd='Refresh']", "Refresh", "ctl00_phG_grid", null, "RP301000");
                    New = new ToolBarButtonGrid("css=div[data-cmd='AddNew']", "Add Row", "ctl00_phG_grid", null, "RP301000");
                    Delete = new ToolBarButtonGrid("css=div[data-cmd='Delete']", "Delete Row", "ctl00_phG_grid", null, "RP301000");
                    Adjust = new ToolBarButtonGrid("css=div[data-cmd='AdjustColumns']", "Fit to Screen", "ctl00_phG_grid", null, "RP301000");
                    Export = new ToolBarButtonGrid("css=div[data-cmd='ExportExcel']", "Export to Excel", "ctl00_phG_grid", null, "RP301000");
                    FilterBar = new ToolBarButtonGrid("css=div[data-cmd='FilterBar']", "FilterBar", "ctl00_phG_grid", null, "RP301000");
                    PageFirst = new ToolBarButtonGrid("css=div[data-cmd='PageFirst']", "Go to First Page (Ctrl+PgUp)", "ctl00_phG_grid", null, "RP301000");
                    PagePrev = new ToolBarButtonGrid("css=div[data-cmd='PagePrev']", "Go to Previous Page (PgUp)", "ctl00_phG_grid", null, "RP301000");
                    PageNext = new ToolBarButtonGrid("css=div[data-cmd='PageNext']", "Go to Next Page (PgDn)", "ctl00_phG_grid", null, "RP301000");
                    PageLast = new ToolBarButtonGrid("css=div[data-cmd='PageLast']", "Go to Last Page (Ctrl+PgDn)", "ctl00_phG_grid", null, "RP301000");
                }
            }
            
            public class c_grid_row {
                
			public FileColumnButton Files {get;set;}
			public NoteColumnButton Notes {get;set;}
			public Selector CustomerID {get;set;}
			public DateSelector StartDate {get;set;}
			public DateSelector EndDate {get;set;}
			public PXNumberEdit RentalID {get;set;}
			public PXTextEdit RentalItemCD {get;set;}
                
                public c_grid_row() {
                    Files = new FileColumnButton("", "Files", "ctl00_phG_grid", 0, "RP301000");
                    Files.ValueType = null;
                    Notes = new NoteColumnButton("", "Notes", "ctl00_phG_grid", 1, "RP301000");
                    Notes.ValueType = null;
                    CustomerID = new Selector("_ctl00_phG_grid_lv0_edCustomerID", "Customer", "ctl00_phG_grid", 2, "RP301000");
                    CustomerID.ValueType = "PX.Web.UI.PXSelector";
                    CustomerID.DataField = "CustomerID";
                    StartDate = new DateSelector("_ctl00_phG_grid_lv0_edStartDate", "Start Date", "ctl00_phG_grid", 3, "RP301000");
                    StartDate.ValueType = "PX.Web.UI.PXDateTimeEdit";
                    StartDate.DataField = "StartDate";
                    EndDate = new DateSelector("_ctl00_phG_grid_lv0_edEndDate", "End Date", "ctl00_phG_grid", 4, "RP301000");
                    EndDate.ValueType = "PX.Web.UI.PXDateTimeEdit";
                    EndDate.DataField = "EndDate";
                    RentalID = new PXNumberEdit("ctl00_phG_grid_en", "RentalID", "ctl00_phG_grid", 5, "RP301000");
                    RentalID.ValueType = "PX.Web.UI.PXNumberEdit";
                    RentalID.DataField = "RentalID";
                    RentalItemCD = new PXTextEdit("ctl00_phG_grid_em", "Rental Item Code", "ctl00_phG_grid", 6, "RP301000");
                    RentalItemCD.ValueType = "PX.Web.UI.PXTextEdit";
                    RentalItemCD.DataField = "RentalItemCD";
                }
            }
            
            public class c_grid_header {
                
				public SelectorColumnFilter CustomerID {get;set;}
				public DateSelectorColumnFilter StartDate {get;set;}
				public DateSelectorColumnFilter EndDate {get;set;}
				public PXNumberEditColumnFilter RentalID {get;set;}
				public PXTextEditColumnFilter RentalItemCD {get;set;}
                
                public c_grid_header(c_grid_row row) {
                    CustomerID = new SelectorColumnFilter(row.CustomerID);
                    StartDate = new DateSelectorColumnFilter(row.StartDate);
                    EndDate = new DateSelectorColumnFilter(row.EndDate);
                    RentalID = new PXNumberEditColumnFilter(row.RentalID);
                    RentalItemCD = new PXTextEditColumnFilter(row.RentalItemCD);
                }
            }
        }
    }
}
