using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace Harpy
{
    [Static]
    partial interface HarpyConstants
    {
        // extern double HarpyVersionNumber;
        [Field("HarpyVersionNumber", "__Internal")]
        double HarpyVersionNumber { get; }

        // extern const unsigned char [] HarpyVersionString;
        [Field("HarpyVersionString", "__Internal")]
        NSString HarpyVersionString { get; }

        // extern NSString *const HarpyLanguageArabic;
        [Field("HarpyLanguageArabic", "__Internal")]
        NSString HarpyLanguageArabic { get; }

        // extern NSString *const HarpyLanguageArmenian;
        [Field("HarpyLanguageArmenian", "__Internal")]
        NSString HarpyLanguageArmenian { get; }

        // extern NSString *const HarpyLanguageBasque;
        [Field("HarpyLanguageBasque", "__Internal")]
        NSString HarpyLanguageBasque { get; }

        // extern NSString *const HarpyLanguageChineseSimplified;
        [Field("HarpyLanguageChineseSimplified", "__Internal")]
        NSString HarpyLanguageChineseSimplified { get; }

        // extern NSString *const HarpyLanguageChineseTraditional;
        [Field("HarpyLanguageChineseTraditional", "__Internal")]
        NSString HarpyLanguageChineseTraditional { get; }

        // extern NSString *const HarpyLanguageCroatian;
        [Field("HarpyLanguageCroatian", "__Internal")]
        NSString HarpyLanguageCroatian { get; }

        // extern NSString *const HarpyLanguageCzech;
        [Field("HarpyLanguageCzech", "__Internal")]
        NSString HarpyLanguageCzech { get; }

        // extern NSString *const HarpyLanguageDanish;
        [Field("HarpyLanguageDanish", "__Internal")]
        NSString HarpyLanguageDanish { get; }

        // extern NSString *const HarpyLanguageDutch;
        [Field("HarpyLanguageDutch", "__Internal")]
        NSString HarpyLanguageDutch { get; }

        // extern NSString *const HarpyLanguageEnglish;
        [Field("HarpyLanguageEnglish", "__Internal")]
        NSString HarpyLanguageEnglish { get; }

        // extern NSString *const HarpyLanguageEstonian;
        [Field("HarpyLanguageEstonian", "__Internal")]
        NSString HarpyLanguageEstonian { get; }

        // extern NSString *const HarpyLanguageFinnish;
        [Field("HarpyLanguageFinnish", "__Internal")]
        NSString HarpyLanguageFinnish { get; }

        // extern NSString *const HarpyLanguageFrench;
        [Field("HarpyLanguageFrench", "__Internal")]
        NSString HarpyLanguageFrench { get; }

        // extern NSString *const HarpyLanguageGerman;
        [Field("HarpyLanguageGerman", "__Internal")]
        NSString HarpyLanguageGerman { get; }

        // extern NSString *const HarpyLanguageGreek;
        [Field("HarpyLanguageGreek", "__Internal")]
        NSString HarpyLanguageGreek { get; }

        // extern NSString *const HarpyLanguageHebrew;
        [Field("HarpyLanguageHebrew", "__Internal")]
        NSString HarpyLanguageHebrew { get; }

        // extern NSString *const HarpyLanguageHungarian;
        [Field("HarpyLanguageHungarian", "__Internal")]
        NSString HarpyLanguageHungarian { get; }

        // extern NSString *const HarpyLanguageIndonesian;
        [Field("HarpyLanguageIndonesian", "__Internal")]
        NSString HarpyLanguageIndonesian { get; }

        // extern NSString *const HarpyLanguageItalian;
        [Field("HarpyLanguageItalian", "__Internal")]
        NSString HarpyLanguageItalian { get; }

        // extern NSString *const HarpyLanguageJapanese;
        [Field("HarpyLanguageJapanese", "__Internal")]
        NSString HarpyLanguageJapanese { get; }

        // extern NSString *const HarpyLanguageKorean;
        [Field("HarpyLanguageKorean", "__Internal")]
        NSString HarpyLanguageKorean { get; }

        // extern NSString *const HarpyLanguageLatvian;
        [Field("HarpyLanguageLatvian", "__Internal")]
        NSString HarpyLanguageLatvian { get; }

        // extern NSString *const HarpyLanguageLithuanian;
        [Field("HarpyLanguageLithuanian", "__Internal")]
        NSString HarpyLanguageLithuanian { get; }

        // extern NSString *const HarpyLanguageMalay;
        [Field("HarpyLanguageMalay", "__Internal")]
        NSString HarpyLanguageMalay { get; }

        // extern NSString *const HarpyLanguageNorwegian;
        [Field("HarpyLanguageNorwegian", "__Internal")]
        NSString HarpyLanguageNorwegian { get; }

        // extern NSString *const HarpyLanguagePersian;
        [Field("HarpyLanguagePersian", "__Internal")]
        NSString HarpyLanguagePersian { get; }

        // extern NSString *const HarpyLanguagePersianIran;
        [Field("HarpyLanguagePersianIran", "__Internal")]
        NSString HarpyLanguagePersianIran { get; }

        // extern NSString *const HarpyLanguagePersianAfghanistan;
        [Field("HarpyLanguagePersianAfghanistan", "__Internal")]
        NSString HarpyLanguagePersianAfghanistan { get; }

        // extern NSString *const HarpyLanguagePolish;
        [Field("HarpyLanguagePolish", "__Internal")]
        NSString HarpyLanguagePolish { get; }

        // extern NSString *const HarpyLanguagePortugueseBrazil;
        [Field("HarpyLanguagePortugueseBrazil", "__Internal")]
        NSString HarpyLanguagePortugueseBrazil { get; }

        // extern NSString *const HarpyLanguagePortuguesePortugal;
        [Field("HarpyLanguagePortuguesePortugal", "__Internal")]
        NSString HarpyLanguagePortuguesePortugal { get; }

        // extern NSString *const HarpyLanguageRussian;
        [Field("HarpyLanguageRussian", "__Internal")]
        NSString HarpyLanguageRussian { get; }

        // extern NSString *const HarpyLanguageSerbianCyrillic;
        [Field("HarpyLanguageSerbianCyrillic", "__Internal")]
        NSString HarpyLanguageSerbianCyrillic { get; }

        // extern NSString *const HarpyLanguageSerbianLatin;
        [Field("HarpyLanguageSerbianLatin", "__Internal")]
        NSString HarpyLanguageSerbianLatin { get; }

        // extern NSString *const HarpyLanguageSlovenian;
        [Field("HarpyLanguageSlovenian", "__Internal")]
        NSString HarpyLanguageSlovenian { get; }

        // extern NSString *const HarpyLanguageSwedish;
        [Field("HarpyLanguageSwedish", "__Internal")]
        NSString HarpyLanguageSwedish { get; }

        // extern NSString *const HarpyLanguageSpanish;
        [Field("HarpyLanguageSpanish", "__Internal")]
        NSString HarpyLanguageSpanish { get; }

        // extern NSString *const HarpyLanguageThai;
        [Field("HarpyLanguageThai", "__Internal")]
        NSString HarpyLanguageThai { get; }

        // extern NSString *const HarpyLanguageTurkish;
        [Field("HarpyLanguageTurkish", "__Internal")]
        NSString HarpyLanguageTurkish { get; }

        // extern NSString *const HarpyLanguageUkrainian;
        [Field("HarpyLanguageUkrainian", "__Internal")]
        NSString HarpyLanguageUkrainian { get; }

        // extern NSString *const HarpyLanguageUrdu;
        [Field("HarpyLanguageUrdu", "__Internal")]
        NSString HarpyLanguageUrdu { get; }

        // extern NSString *const HarpyLanguageVietnamese;
        [Field("HarpyLanguageVietnamese", "__Internal")]
        NSString HarpyLanguageVietnamese { get; }
    }

    partial interface IHarpyDelegate
    {

    }

    // @protocol HarpyDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface HarpyDelegate
    {
        // @optional -(void)harpyDidShowUpdateDialog;
        [Export("harpyDidShowUpdateDialog")]
        void HarpyDidShowUpdateDialog();

        // @optional -(void)harpyUserDidLaunchAppStore;
        [Export("harpyUserDidLaunchAppStore")]
        void HarpyUserDidLaunchAppStore();

        // @optional -(void)harpyUserDidSkipVersion;
        [Export("harpyUserDidSkipVersion")]
        void HarpyUserDidSkipVersion();

        // @optional -(void)harpyUserDidCancel;
        [Export("harpyUserDidCancel")]
        void HarpyUserDidCancel();

        // @optional -(void)harpyDidDetectNewVersionWithoutAlert:(NSString *)message;
        [Export("harpyDidDetectNewVersionWithoutAlert:")]
        void HarpyDidDetectNewVersionWithoutAlert(string message);
    }

    // @interface Harpy : NSObject
    [BaseType(typeof(NSObject))]
    interface Harpy
    {
        [Wrap("WeakDelegate")]
        IHarpyDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<HarpyDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIViewController * presentingViewController;
        [Export("presentingViewController", ArgumentSemantic.Strong)]
        UIViewController PresentingViewController { get; set; }

        // @property (readonly, copy, nonatomic) NSString * currentAppStoreVersion;
        [Export("currentAppStoreVersion")]
        string CurrentAppStoreVersion { get; }

        // @property (nonatomic, strong) NSString * appName;
        [Export("appName", ArgumentSemantic.Strong)]
        string AppName { get; set; }

        // @property (getter = isDebugEnabled, assign, nonatomic) BOOL debugEnabled;
        [Export("debugEnabled")]
        bool DebugEnabled { [Bind("isDebugEnabled")] get; set; }

        // @property (assign, nonatomic) HarpyAlertType alertType;
        [Export("alertType", ArgumentSemantic.Assign)]
        HarpyAlertType AlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType majorUpdateAlertType;
        [Export("majorUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType MajorUpdateAlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType minorUpdateAlertType;
        [Export("minorUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType MinorUpdateAlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType patchUpdateAlertType;
        [Export("patchUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType PatchUpdateAlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType revisionUpdateAlertType;
        [Export("revisionUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType RevisionUpdateAlertType { get; set; }

        // @property (copy, nonatomic) NSString * countryCode;
        [Export("countryCode")]
        string CountryCode { get; set; }

        // @property (copy, nonatomic) NSString * forceLanguageLocalization;
        [Export("forceLanguageLocalization")]
        string ForceLanguageLocalization { get; set; }

        // @property (nonatomic, strong) UIColor * alertControllerTintColor;
        [Export("alertControllerTintColor", ArgumentSemantic.Strong)]
        UIColor AlertControllerTintColor { get; set; }

        // @property (assign, nonatomic) NSUInteger showAlertAfterCurrentVersionHasBeenReleasedForDays;
        [Export("showAlertAfterCurrentVersionHasBeenReleasedForDays")]
        nuint ShowAlertAfterCurrentVersionHasBeenReleasedForDays { get; set; }

        // +(Harpy *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        Harpy SharedInstance { get; }

        // -(void)checkVersion;
        [Export("checkVersion")]
        void CheckVersion();

        // -(void)checkVersionDaily;
        [Export("checkVersionDaily")]
        void CheckVersionDaily();

        // -(void)checkVersionWeekly;
        [Export("checkVersionWeekly")]
        void CheckVersionWeekly();

        // -(NSString *)testLocalizedStringForKey:(NSString *)stringKey;
        [Export("testLocalizedStringForKey:")]
        string TestLocalizedStringForKey(string stringKey);

        // -(void)testSetCurrentInstalledVersion:(NSString *)version;
        [Export("testSetCurrentInstalledVersion:")]
        void TestSetCurrentInstalledVersion(string version);

        // -(void)testSetCurrentAppStoreVersion:(NSString *)version;
        [Export("testSetCurrentAppStoreVersion:")]
        void TestSetCurrentAppStoreVersion(string version);

        // -(BOOL)testIsAppStoreVersionNewer;
        [Export("testIsAppStoreVersionNewer")]
        bool TestIsAppStoreVersionNewer { get; }
    }
}
