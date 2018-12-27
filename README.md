# Harpy_Xamarin.iOS
### Notify users when a new version of your app is available and prompt them to upgrade.

Port of Xamarin iOS of the [Harpy](https://github.com/ArtSabintsev/Harpy)


## About
**Harpy** checks a user's currently installed version of your iOS app against the version that is currently available in the App Store. If a new version is available, an alert can be presented to the user informing them of the newer version, and giving them the option to update the application.

Harpy is built to work with the [Semantic Versioning](http://www.semver.org) system.
- Semantic Versioning is a three number versioning system (e.g., 1.0.0)
- Harpy also supports two-number versioning (e.g., 1.0)
- Harpy also supports four-number versioning (e.g., 1.0.0.0)
- Harpy only works with numbers.

## Screenshots

- The **left picture** forces the user to update the app.
- The **center picture** gives the user the option to update the app.
- The **right picture** gives the user the option to skip the current update.
- These options are controlled by the `HarpyAlertType` enum that is found in `Harpy.h`.

<img src="https://github.com/ArtSabintsev/Harpy/blob/master/Assets/picForcedUpdate.png?raw=true" height="480"> <img src="https://github.com/ArtSabintsev/Harpy/blob/master/Assets/picOptionalUpdate.png?raw=true" height="480"> <img src="https://github.com/ArtSabintsev/Harpy/blob/master/Assets/picSkippedUpdate.png?raw=true" height="480">

## How to use

Please reference [the sample project](https://github.com/Wenfengcheng/Harpy_Xamarin.iOS/blob/master/Harpy/Harpy.Sample/AppDelegate.cs)

## Localization
Harpy is localized for
- Arabic
- Armenian
- Basque
- Chinese (Simplified and Traditional)
- Croatian
- Czech
- Danish
- Dutch
- English
- Estonian
- Finnish
- French
- German
- Greek
- Hebrew
- Hungarian
- Indonesian
- Italian
- Japanese
- Korean
- Latvian
- Lithuanian
- Malay
- Norwegian (Bokmål)
- Persian (Iran, Afghanistan, Persian)
- Polish
- Portuguese (Brazil and Portugal)
- Russian
- Serbian (Cyrillic and Latin)
- Slovenian
- Spanish
- Swedish
- Thai
- Turkish
- Ukrainian
- Urdu
- Vietnamese

You may want the update dialog to *always* appear in a certain language, ignoring iOS's language setting (e.g. apps released in a specific country).

You can enable it like this:

``` C#
Harpy.SharedInstance.ForceLanguageLocalization = Constants.HarpyLanguageChineseSimplified;
```

## Device Compatibility
If an app update is available, Harpy checks to make sure that the version of iOS on the user's device is compatible the one that is required by the app update. For example, if a user has iOS 9 installed on their device, but the app update requires iOS 10, an alert will not be shown. This takes care of the *false positive* case regarding app updating.

## Testing Harpy
Temporarily change the version string in *Info.plist* to an older version than the one that's currently available in the App Store. Afterwards, build and run your app, and you should see the alert.

If you currently don't have an app in the store, change your bundleID to one that is already in the store. In the sample app packaged with this library, we use the [Baidu Map](https://itunes.apple.com/cn/app/%E7%99%BE%E5%BA%A6%E5%9C%B0%E5%9B%BE-%E5%87%BA%E8%A1%8C%E5%AF%BC%E8%88%AA%E5%BF%85%E5%A4%87%E7%9A%84%E6%99%BA%E8%83%BD%E8%B7%AF%E7%BA%BF%E8%A7%84%E5%88%92%E8%BD%AF%E4%BB%B6/id452186370?mt=8) app's bundleID: `com.baidu.map`.

## Important Note on App Store Submissions
The App Store reviewer will **not** see the alert.

## Phased Releases
In 2017, Apple announced the [ability to rollout app updates gradually (a.k.a. Phased Releases)](https://itunespartner.apple.com/en/apps/faq/Managing%20Your%20Apps_Submission%20Process). Harpy will continue to work as it has in the past, presenting an update modal to _all_ users. If you opt-in to a phased rollout for a specific version, you will need to remotely disable Harpy until the rollout is done.
