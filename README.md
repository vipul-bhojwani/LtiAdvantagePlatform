# LTI Advantage Platform

Sample LTI Advantage Platform using .NET Core 2.1. So that it has a purpose (other than as a reference code sample), you can use it to [test](https://advantageplatform.azurewebsites.net/) LTI 1.3 Tools. There is a sample LTI Advantage Tool project over [here](https://github.com/andyfmiller/LtiAdvantageTool).

## Supported Features

- LTI 1.3 Core (launch)
   - Register yourself on the Platform to access the Clients UI and create a Client ID for yourself (this is similar to Google's Developer Console).
   - The Platform supports [OpenId Connect Discovery](https://openid.net/specs/openid-connect-discovery-1_0.html) so Tools can discover the JWKS URL by examining the response to [(Issuer)/.well-known/openid-configuration](https://advantageplatform.azurewebsites.net/.well-known/openid-configuration).
- The rest of LTI Advantage is coming soon (that's the plan anyway)

## Dependencies

This web application is based on the current .NET Core Web Application template for Razor Pages.
Almost all the custom code is for managing the Clients and inserting your Tool into the Platform or Course.
The packages and projects below take care of all the core OpenId Connect and OAuth 2.0 stuff.

<dl>
  <dt>Microsoft.AspNetCore.App (https://www.nuget.org/packages/Microsoft.AspNetCore.App)</dt>
  <dd>This provides the framework for the web application.</dd>
  <dt>IdentityServer4.AspNetIdentity (https://www.nuget.org/packages/IdentityServer4.AspNetIdentity)</dt>
  <dd>This package manages the private and public keys, signing the JWT, provides a well known discovery API, and
    a KeySet interface.</dd>
  <dt>System.IdentityModel.Tokens.Jwt (https://www.nuget.org/packages/System.IdentityModel.Tokens.Jwt)</dt>
  <dd>This package provides some JWT functionality, but may be removed in favor of IdentityServer.</dd>
  <dt>LtiAdvantageLibrary (https://github.com/andyfmiller/LtiAdvantageLibrary)</dt>
  <dd>This library provides some LTI specific features.</dd>
</dl>
