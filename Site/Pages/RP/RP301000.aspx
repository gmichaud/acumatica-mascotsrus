<%@ Page AutoEventWireup="true" CodeFile="RP301000.aspx.cs" Inherits="Page_RP301000" Language="C#" MasterPageFile="~/MasterPages/FormDetail.master" Title="Untitled Page" ValidateRequest="false" %>

<%@ MasterType VirtualPath="~/MasterPages/FormDetail.master" %>

<asp:Content ID="cont1" runat="Server" ContentPlaceHolderID="phDS">
    <px:PXDataSource ID="ds" runat="server" PrimaryView="Items" TypeName="Acumatica.RentalPro.RentalManagement" Visible="True" Width="100%">
        <CallbackCommands>
            <px:PXDSCallbackCommand CommitChanges="True" Name="Save"/>
        </CallbackCommands>
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" runat="Server" ContentPlaceHolderID="phF">
    <px:PXFormView ID="form" runat="server" DataMember="Items" DataSourceID="ds" Style="z-index: 100" Width="100%">
        <Template>
            <px:PXLayoutRule ID="PXLayoutRule1" runat="server" ControlSize="M" LabelsWidth="SM" StartColumn="True"/>
            <px:PXSelector ID="edRentalItemCD" runat="server" DataField="RentalItemCD"/>
            <px:PXTextEdit ID="edDescription" runat="server" DataField="Description"/>
            <px:PXNumberEdit ID="edCost" runat="server" DataField="Cost"/>
            <px:PXTextEdit ID="edSerialNumber" runat="server" CommitChanges="true" DataField="SerialNumber"/>
            <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="S" ControlSize="XM"/>
            <px:PXImageUploader  Width="395px" Height="275"  ID="imgUploader" runat="server" AllowUpload="True" ViewOnly="True" ArrowsOutside="True" LabelText="&nbsp"/>
        </Template>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" />
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" runat="Server" ContentPlaceHolderID="phG">
    <px:PXGrid ID="grid" runat="server" Caption="Rentals" DataSourceID="ds" Height="150px" SkinID="Details" Style="z-index: 100" Width="100%">
        <Levels>
            <px:PXGridLevel DataMember="Rentals">
                <RowTemplate>
                    <px:PXLayoutRule ID="PXLayoutRule2" runat="server" ControlSize="XM" LabelsWidth="SM" StartColumn="True"/>
                    <px:PXSelector ID="edCustomerID" runat="server" DataField="CustomerID"/>
                    <px:PXDateTimeEdit ID="edStartDate" runat="server" DataField="StartDate"/>
                    <px:PXDateTimeEdit ID="edEndDate" runat="server" DataField="EndDate"/>
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="CustomerID" TextAlign="Left" Width="200px"/>
                    <px:PXGridColumn DataField="StartDate" TextAlign="Right" Width="100px"/>
                    <px:PXGridColumn DataField="EndDate" TextAlign="Right" Width="100px"/>
                </Columns>
                <Layout FormViewHeight="" />
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="150" />
        <ActionBar>
            <Actions>
                <NoteShow Enabled="False" />
            </Actions>
        </ActionBar>
    </px:PXGrid>
</asp:Content>
