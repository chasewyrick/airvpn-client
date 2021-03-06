// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace AirVPN.UI.Osx
{
	[Register ("WindowPreferencesController")]
	partial class WindowPreferencesController
	{
		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboAdvancedManifestRefresh { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboDnsSwitchMode { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboGeneralOsxInterfaceStyle { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboIpV6 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboLockMode { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboOpenVpnRcvBuf { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboOpenVpnSndBuf { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboProxyAuthentication { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboProxyType { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboRoutesOtherwise { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedCheckRoute { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedExpertMode { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedNetworkLocking { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedOpenVpnDirectivesDefaultSkip { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedPingerEnabled { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkConnect { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkDnsCheck { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkExitConfirm { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkGeneralOsxNotifications { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkGeneralOsxVisible { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkGeneralStartLast { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkLockAllowPing { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkLockAllowPrivate { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkLoggingEnabled { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkLogLevelDebug { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeAutomatic { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh22 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh22Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh53 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh80 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsl443 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp2018 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp2018Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp443 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp53 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp80 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTor { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp2018 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp2018Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp443 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp443Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp53 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp53Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp80 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp80Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkNetLock { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkRouteRemoveDefaultGateway { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdAdvancedEventsClear { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdAdvancedEventsEdit { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdAdvancedHelp { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdAdvancedOpenVpnPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdCancel { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdDnsAdd { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdDnsEdit { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdDnsRemove { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdGeneralTos { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdLockHelp { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdModeHelp { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdModeTorTest { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdRouteAdd { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdRouteEdit { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdRouteRemove { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdSave { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField LblDnsServers { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField LblLockRoutingOutWarning { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField LblLoggingHelp { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField LblOpenVpnRcvBuf { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField LblOpenVpnSndBuf { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField LblRoutesNetworkLockWarning { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTableView TableAdvancedEvents { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTableView TableDnsServers { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTableView TableRoutes { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtAdvancedOpenVpnDirectivesCustom { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtAdvancedOpenVpnDirectivesDefault { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtAdvancedOpenVpnPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtLockAllowedIPS { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtLoggingComputedPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtLoggingPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtModeTorControlPassword { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtModeTorControlPort { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtModeTorHost { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtModeTorPort { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyHost { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyLogin { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyPassword { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyPort { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CboAdvancedManifestRefresh != null) {
				CboAdvancedManifestRefresh.Dispose ();
				CboAdvancedManifestRefresh = null;
			}

			if (CboDnsSwitchMode != null) {
				CboDnsSwitchMode.Dispose ();
				CboDnsSwitchMode = null;
			}

			if (CboGeneralOsxInterfaceStyle != null) {
				CboGeneralOsxInterfaceStyle.Dispose ();
				CboGeneralOsxInterfaceStyle = null;
			}

			if (CboIpV6 != null) {
				CboIpV6.Dispose ();
				CboIpV6 = null;
			}

			if (CboLockMode != null) {
				CboLockMode.Dispose ();
				CboLockMode = null;
			}

			if (CboOpenVpnSndBuf != null) {
				CboOpenVpnSndBuf.Dispose ();
				CboOpenVpnSndBuf = null;
			}

			if (CboOpenVpnRcvBuf != null) {
				CboOpenVpnRcvBuf.Dispose ();
				CboOpenVpnRcvBuf = null;
			}

			if (CboProxyAuthentication != null) {
				CboProxyAuthentication.Dispose ();
				CboProxyAuthentication = null;
			}

			if (CboProxyType != null) {
				CboProxyType.Dispose ();
				CboProxyType = null;
			}

			if (CboRoutesOtherwise != null) {
				CboRoutesOtherwise.Dispose ();
				CboRoutesOtherwise = null;
			}

			if (ChkAdvancedCheckRoute != null) {
				ChkAdvancedCheckRoute.Dispose ();
				ChkAdvancedCheckRoute = null;
			}

			if (ChkAdvancedExpertMode != null) {
				ChkAdvancedExpertMode.Dispose ();
				ChkAdvancedExpertMode = null;
			}

			if (ChkAdvancedNetworkLocking != null) {
				ChkAdvancedNetworkLocking.Dispose ();
				ChkAdvancedNetworkLocking = null;
			}

			if (ChkAdvancedOpenVpnDirectivesDefaultSkip != null) {
				ChkAdvancedOpenVpnDirectivesDefaultSkip.Dispose ();
				ChkAdvancedOpenVpnDirectivesDefaultSkip = null;
			}

			if (ChkAdvancedPingerEnabled != null) {
				ChkAdvancedPingerEnabled.Dispose ();
				ChkAdvancedPingerEnabled = null;
			}

			if (ChkConnect != null) {
				ChkConnect.Dispose ();
				ChkConnect = null;
			}

			if (ChkDnsCheck != null) {
				ChkDnsCheck.Dispose ();
				ChkDnsCheck = null;
			}

			if (ChkExitConfirm != null) {
				ChkExitConfirm.Dispose ();
				ChkExitConfirm = null;
			}

			if (ChkGeneralOsxNotifications != null) {
				ChkGeneralOsxNotifications.Dispose ();
				ChkGeneralOsxNotifications = null;
			}

			if (ChkGeneralOsxVisible != null) {
				ChkGeneralOsxVisible.Dispose ();
				ChkGeneralOsxVisible = null;
			}

			if (ChkGeneralStartLast != null) {
				ChkGeneralStartLast.Dispose ();
				ChkGeneralStartLast = null;
			}

			if (ChkLockAllowPing != null) {
				ChkLockAllowPing.Dispose ();
				ChkLockAllowPing = null;
			}

			if (ChkLockAllowPrivate != null) {
				ChkLockAllowPrivate.Dispose ();
				ChkLockAllowPrivate = null;
			}

			if (ChkLoggingEnabled != null) {
				ChkLoggingEnabled.Dispose ();
				ChkLoggingEnabled = null;
			}

			if (ChkLogLevelDebug != null) {
				ChkLogLevelDebug.Dispose ();
				ChkLogLevelDebug = null;
			}

			if (ChkModeAutomatic != null) {
				ChkModeAutomatic.Dispose ();
				ChkModeAutomatic = null;
			}

			if (ChkModeSsh22 != null) {
				ChkModeSsh22.Dispose ();
				ChkModeSsh22 = null;
			}

			if (ChkModeSsh22Alt != null) {
				ChkModeSsh22Alt.Dispose ();
				ChkModeSsh22Alt = null;
			}

			if (ChkModeSsh53 != null) {
				ChkModeSsh53.Dispose ();
				ChkModeSsh53 = null;
			}

			if (ChkModeSsh80 != null) {
				ChkModeSsh80.Dispose ();
				ChkModeSsh80 = null;
			}

			if (ChkModeSsl443 != null) {
				ChkModeSsl443.Dispose ();
				ChkModeSsl443 = null;
			}

			if (ChkModeTcp2018 != null) {
				ChkModeTcp2018.Dispose ();
				ChkModeTcp2018 = null;
			}

			if (ChkModeTcp2018Alt != null) {
				ChkModeTcp2018Alt.Dispose ();
				ChkModeTcp2018Alt = null;
			}

			if (ChkModeTcp443 != null) {
				ChkModeTcp443.Dispose ();
				ChkModeTcp443 = null;
			}

			if (ChkModeTcp53 != null) {
				ChkModeTcp53.Dispose ();
				ChkModeTcp53 = null;
			}

			if (ChkModeTcp80 != null) {
				ChkModeTcp80.Dispose ();
				ChkModeTcp80 = null;
			}

			if (ChkModeTor != null) {
				ChkModeTor.Dispose ();
				ChkModeTor = null;
			}

			if (ChkModeUdp2018 != null) {
				ChkModeUdp2018.Dispose ();
				ChkModeUdp2018 = null;
			}

			if (ChkModeUdp2018Alt != null) {
				ChkModeUdp2018Alt.Dispose ();
				ChkModeUdp2018Alt = null;
			}

			if (ChkModeUdp443 != null) {
				ChkModeUdp443.Dispose ();
				ChkModeUdp443 = null;
			}

			if (ChkModeUdp443Alt != null) {
				ChkModeUdp443Alt.Dispose ();
				ChkModeUdp443Alt = null;
			}

			if (ChkModeUdp53 != null) {
				ChkModeUdp53.Dispose ();
				ChkModeUdp53 = null;
			}

			if (ChkModeUdp53Alt != null) {
				ChkModeUdp53Alt.Dispose ();
				ChkModeUdp53Alt = null;
			}

			if (ChkModeUdp80 != null) {
				ChkModeUdp80.Dispose ();
				ChkModeUdp80 = null;
			}

			if (ChkModeUdp80Alt != null) {
				ChkModeUdp80Alt.Dispose ();
				ChkModeUdp80Alt = null;
			}

			if (ChkNetLock != null) {
				ChkNetLock.Dispose ();
				ChkNetLock = null;
			}

			if (ChkRouteRemoveDefaultGateway != null) {
				ChkRouteRemoveDefaultGateway.Dispose ();
				ChkRouteRemoveDefaultGateway = null;
			}

			if (CmdAdvancedEventsClear != null) {
				CmdAdvancedEventsClear.Dispose ();
				CmdAdvancedEventsClear = null;
			}

			if (CmdAdvancedEventsEdit != null) {
				CmdAdvancedEventsEdit.Dispose ();
				CmdAdvancedEventsEdit = null;
			}

			if (CmdAdvancedHelp != null) {
				CmdAdvancedHelp.Dispose ();
				CmdAdvancedHelp = null;
			}

			if (CmdAdvancedOpenVpnPath != null) {
				CmdAdvancedOpenVpnPath.Dispose ();
				CmdAdvancedOpenVpnPath = null;
			}

			if (CmdCancel != null) {
				CmdCancel.Dispose ();
				CmdCancel = null;
			}

			if (CmdDnsAdd != null) {
				CmdDnsAdd.Dispose ();
				CmdDnsAdd = null;
			}

			if (CmdDnsEdit != null) {
				CmdDnsEdit.Dispose ();
				CmdDnsEdit = null;
			}

			if (CmdDnsRemove != null) {
				CmdDnsRemove.Dispose ();
				CmdDnsRemove = null;
			}

			if (CmdGeneralTos != null) {
				CmdGeneralTos.Dispose ();
				CmdGeneralTos = null;
			}

			if (CmdLockHelp != null) {
				CmdLockHelp.Dispose ();
				CmdLockHelp = null;
			}

			if (CmdModeHelp != null) {
				CmdModeHelp.Dispose ();
				CmdModeHelp = null;
			}

			if (CmdModeTorTest != null) {
				CmdModeTorTest.Dispose ();
				CmdModeTorTest = null;
			}

			if (CmdRouteAdd != null) {
				CmdRouteAdd.Dispose ();
				CmdRouteAdd = null;
			}

			if (CmdRouteEdit != null) {
				CmdRouteEdit.Dispose ();
				CmdRouteEdit = null;
			}

			if (CmdRouteRemove != null) {
				CmdRouteRemove.Dispose ();
				CmdRouteRemove = null;
			}

			if (CmdSave != null) {
				CmdSave.Dispose ();
				CmdSave = null;
			}

			if (LblDnsServers != null) {
				LblDnsServers.Dispose ();
				LblDnsServers = null;
			}

			if (LblLockRoutingOutWarning != null) {
				LblLockRoutingOutWarning.Dispose ();
				LblLockRoutingOutWarning = null;
			}

			if (LblLoggingHelp != null) {
				LblLoggingHelp.Dispose ();
				LblLoggingHelp = null;
			}

			if (LblOpenVpnSndBuf != null) {
				LblOpenVpnSndBuf.Dispose ();
				LblOpenVpnSndBuf = null;
			}

			if (LblOpenVpnRcvBuf != null) {
				LblOpenVpnRcvBuf.Dispose ();
				LblOpenVpnRcvBuf = null;
			}

			if (LblRoutesNetworkLockWarning != null) {
				LblRoutesNetworkLockWarning.Dispose ();
				LblRoutesNetworkLockWarning = null;
			}

			if (TableAdvancedEvents != null) {
				TableAdvancedEvents.Dispose ();
				TableAdvancedEvents = null;
			}

			if (TableDnsServers != null) {
				TableDnsServers.Dispose ();
				TableDnsServers = null;
			}

			if (TableRoutes != null) {
				TableRoutes.Dispose ();
				TableRoutes = null;
			}

			if (TxtAdvancedOpenVpnDirectivesCustom != null) {
				TxtAdvancedOpenVpnDirectivesCustom.Dispose ();
				TxtAdvancedOpenVpnDirectivesCustom = null;
			}

			if (TxtAdvancedOpenVpnDirectivesDefault != null) {
				TxtAdvancedOpenVpnDirectivesDefault.Dispose ();
				TxtAdvancedOpenVpnDirectivesDefault = null;
			}

			if (TxtAdvancedOpenVpnPath != null) {
				TxtAdvancedOpenVpnPath.Dispose ();
				TxtAdvancedOpenVpnPath = null;
			}

			if (TxtLockAllowedIPS != null) {
				TxtLockAllowedIPS.Dispose ();
				TxtLockAllowedIPS = null;
			}

			if (TxtLoggingComputedPath != null) {
				TxtLoggingComputedPath.Dispose ();
				TxtLoggingComputedPath = null;
			}

			if (TxtLoggingPath != null) {
				TxtLoggingPath.Dispose ();
				TxtLoggingPath = null;
			}

			if (TxtModeTorControlPassword != null) {
				TxtModeTorControlPassword.Dispose ();
				TxtModeTorControlPassword = null;
			}

			if (TxtModeTorControlPort != null) {
				TxtModeTorControlPort.Dispose ();
				TxtModeTorControlPort = null;
			}

			if (TxtModeTorHost != null) {
				TxtModeTorHost.Dispose ();
				TxtModeTorHost = null;
			}

			if (TxtModeTorPort != null) {
				TxtModeTorPort.Dispose ();
				TxtModeTorPort = null;
			}

			if (TxtProxyHost != null) {
				TxtProxyHost.Dispose ();
				TxtProxyHost = null;
			}

			if (TxtProxyLogin != null) {
				TxtProxyLogin.Dispose ();
				TxtProxyLogin = null;
			}

			if (TxtProxyPassword != null) {
				TxtProxyPassword.Dispose ();
				TxtProxyPassword = null;
			}

			if (TxtProxyPort != null) {
				TxtProxyPort.Dispose ();
				TxtProxyPort = null;
			}
		}
	}

	[Register ("WindowPreferences")]
	partial class WindowPreferences
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
