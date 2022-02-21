<div id="top"></div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    <li><a href="#usage">Usage examples</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

This is a simple example of how you may use Ms AppCenter for events and exceptions tracking.

<p align="right">(<a href="#top">back to top</a>)</p>


### Built With

* [Xamarin.Forms](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)
* [FreshMVVM](https://github.com/rid00z/FreshMvvm)
* [Microsoft.AppCenter.Analytics](https://www.nuget.org/packages/Microsoft.AppCenter.Analytics/)
* [Microsoft.AppCenter.Crashes](https://www.nuget.org/packages/Microsoft.AppCenter.Crashes/)

<p align="right">(<a href="#top">back to top</a>)</p>


### Installation

1. Get a secret key for each project at [https://appcenter.ms/](https://appcenter.ms/)
2. Clone the repo
   ```sh
   git clone https://github.com/reminmax/MsAppCenter
   ```
4. Enter your secret keys in `app.xaml.cs` file instead of
   ```
   {Your iOS App secret here};
   ```
   and 
   ```
   {Your iOS App secret here} {Your iOS App secret here};
   ```

<p align="right">(<a href="#top">back to top</a>)</p>


<!-- USAGE EXAMPLES -->
## Usage examples

Get information about the number of users, the session duration, top devices and more.
Collect crash data from all devices.

For more examples, please refer to the Ms documentation
[Crashes](https://docs.microsoft.com/en-us/appcenter/sdk/crashes/xamarin)
[Analytics](https://docs.microsoft.com/en-us/appcenter/analytics/)

<p align="right">(<a href="#top">back to top</a>)</p>
