// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_ScmSiteBasicPublishingCredentialsPolicyResource
    {
        // Get SCM Allowed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSCMAllowed()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetPublishingCredentialsPolicy.json
            // this example is just showing the usage of "WebApps_GetScmAllowed" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScmSiteBasicPublishingCredentialsPolicyResource created on azure
            // for more information of creating ScmSiteBasicPublishingCredentialsPolicyResource, please refer to the document of ScmSiteBasicPublishingCredentialsPolicyResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testSite";
            ResourceIdentifier scmSiteBasicPublishingCredentialsPolicyResourceId = ScmSiteBasicPublishingCredentialsPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ScmSiteBasicPublishingCredentialsPolicyResource scmSiteBasicPublishingCredentialsPolicy = client.GetScmSiteBasicPublishingCredentialsPolicyResource(scmSiteBasicPublishingCredentialsPolicyResourceId);

            // invoke the operation
            ScmSiteBasicPublishingCredentialsPolicyResource result = await scmSiteBasicPublishingCredentialsPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CsmPublishingCredentialsPoliciesEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update SCM Allowed
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateSCMAllowed()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/UpdatePublishingCredentialsPolicy.json
            // this example is just showing the usage of "WebApps_UpdateScmAllowed" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScmSiteBasicPublishingCredentialsPolicyResource created on azure
            // for more information of creating ScmSiteBasicPublishingCredentialsPolicyResource, please refer to the document of ScmSiteBasicPublishingCredentialsPolicyResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testSite";
            ResourceIdentifier scmSiteBasicPublishingCredentialsPolicyResourceId = ScmSiteBasicPublishingCredentialsPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            ScmSiteBasicPublishingCredentialsPolicyResource scmSiteBasicPublishingCredentialsPolicy = client.GetScmSiteBasicPublishingCredentialsPolicyResource(scmSiteBasicPublishingCredentialsPolicyResourceId);

            // invoke the operation
            CsmPublishingCredentialsPoliciesEntityData data = new CsmPublishingCredentialsPoliciesEntityData()
            {
                Allow = true,
            };
            ArmOperation<ScmSiteBasicPublishingCredentialsPolicyResource> lro = await scmSiteBasicPublishingCredentialsPolicy.CreateOrUpdateAsync(WaitUntil.Completed, data);
            ScmSiteBasicPublishingCredentialsPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CsmPublishingCredentialsPoliciesEntityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
