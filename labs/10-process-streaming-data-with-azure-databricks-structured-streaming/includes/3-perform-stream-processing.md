In this unit, you need to complete the exercises within a Databricks Notebook. To begin, you need to have access to an Azure Databricks workspace. You also need an Azure Event Hubs instance in your Azure subscription.

If you are using a pre-provisioned environment, you can skip to the bottom of the page to [Clone the Databricks archive](#clone-the-databricks-archive).

## Unit Pre-requisites

**Microsoft Azure Account**: You will need a valid and active Azure account for the Azure labs. If you do not have one, you can sign up for a [free trial](https://azure.microsoft.com/en-us/free/)

- If you are a Visual Studio Active Subscriber, you are entitled for a $50-$150 credit per month. You can refer to this [link](https://azure.microsoft.com/en-us/pricing/member-offers/msdn-benefits-details/) to find out more including how to activate and start using your monthly Azure credit.

- If you are not a Visual Studio Subscriber, you can sign up for the FREE [Visual Studio Dev Essentials](https://www.visualstudio.com/dev-essentials/) program to create Azure free account (includes 1 year of free services, $200 for 1st month).

The first step toward using Spark Structured Streaming is setting up Azure Event Hubs in your Azure subscription.

## Create an Event Hubs namespace

1. In the Azure portal, select **+ Create a resource**. Enter **event hubs** into the **Search the Marketplace** box, select **Event Hubs** from the results, and then select **Create**.

    ![Screenshot of the Azure portal with selections for creating an event hub](../media/create-event-hubs.PNG)

1. In the **Create Namespace** pane, enter the following information:

   - **Name**: Enter a unique name, such as **databricksdemoeventhubs**. Uniqueness will be indicated by a green check mark.
   - **Pricing tier**: Select **Basic**.
   - **Subscription**: Select the subscription group you're using for this module.
   - **Resource group**: Choose your module resource group.
   - **Location**: Select the location you're using for this module.
   
   Select **Create**.

   ![Screenshot of the "Create Namespace" pane](../media/create-event-hubs-namespace.PNG)

## Create an event hub

1. After your Event Hubs namespace is provisioned, browse to it and add a new event hub by selecting the **+ Event Hub** button on the toolbar.
 
   ![Screenshot of an Event Hubs namespace with the button for adding an event hub highlighted](../media/add-event-hub.PNG)

1. On the **Create Event Hub** pane, enter:

   - **Name**: Enter **databricks-demo-eventhub**.
   - **Partition Count**: Enter **2**.
    
   Select **Create**.

   ![Screenshot of the "Create Event Hub" pane](../media/create-new-event-hubs.PNG)

## Copy the connection string primary key for the shared access policy

1. On the left-hand menu in your Event Hubs namespace, select **Shared access policies** under **Settings**, then select the **RootManageSharedAccessKey** policy.

   ![Shared access policies.](../media/shared-access-policies.png)

2. Copy the connection string for the primary key by selecting the copy button.

   ![Selected shared access policy with information about connection string and primary key](../media/copy-sas-key.png)

3. Save the copied primary key to Notepad.exe or another text editor for later reference.

## Deploy an Azure Databricks workspace

1. Click the following button to open the ARM template in the Azure Portal.
   [Deploy Databricks from the ARM Template](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure%2Fazure-quickstart-templates%2Fmaster%2F101-databricks-workspace%2Fazuredeploy.json)

1. Provide the required values to create your Azure Databricks workspace:

   - **Subscription**: Choose the Azure Subscription in which to deploy the workspace.
   - **Resource Group**: Leave at Create new and provide a name for the new resource group.
   - **Location**: Select a location near you for deployment. For the list of regions supported by Azure Databricks, see [Azure services available by region](https://azure.microsoft.com/regions/services/).
   - **Workspace Name**: Provide a name for your workspace.
   - **Pricing Tier**: Ensure `premium` is selected.

1. Accept the terms and conditions.
1. Select Purchase.
1. The workspace creation takes a few minutes. During workspace creation, the portal displays the Submitting deployment for Azure Databricks tile on the right side. You may need to scroll right on your dashboard to see the tile. There is also a progress bar displayed near the top of the screen. You can watch either area for progress.

## Create a cluster

1. When your Azure Databricks workspace creation is complete, select the link to go to the resource.
1. Select **Launch Workspace** to open your Databricks workspace in a new tab.
1. In the left-hand menu of your Databricks workspace, select **Clusters**.
1. Select **Create Cluster** to add a new cluster.

    ![The create cluster page](../media/create-a-cluster.PNG)

1. Enter a name for your cluster. Use your name or initials to easily differentiate your cluster from your coworkers.
1. Select the **Databricks RuntimeVersion**. We recommend the latest runtime and **Scala 2.11**.
1. Select the default values for the cluster configuration.
1. Select **Create Cluster**.

## Clone the Databricks archive

1. If you do not currently have your Azure Databricks workspace open: in the Azure portal, navigate to your deployed Azure Databricks workspace and select **Launch Workspace**.
1. In the left pane, select **Workspace** > **Users**, and select your username (the entry with the house icon).
1. In the pane that appears, select the arrow next to your name, and select **Import**.

    ![The menu option to import the archive](../media/import-archive.PNG)

1. In the **Import Notebooks** dialog box, select the URL and paste in the following URL:

 ```
  https://github.com/solliancenet/microsoft-learning-paths-databricks-notebooks/blob/master/data-engineering/DBC/10-Structured-Streaming.dbc?raw=true
 ```

1. Select **Import**.
1. Select the **10-Structured-Streaming** folder that appears.

## Complete the following notebook

Open the **1.Structured-Streaming-Concepts** notebook. Make sure you attach your cluster to the notebook before following the instructions and running the cells within.

Within the notebook, you will:

- Stream data from a file and write it out to a distributed file system
- List active streams
- Stop active streams

After you've completed the notebook, return to this screen, and continue to the next step.
