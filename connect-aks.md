To configure kubectl to connect to your Kubernetes cluster, use the az aks get-credentials command. This command downloads credentials and configures the Kubernetes CLI to use them.

    λ az aks get-credentials --resource-group myResourceGroup --name myAKSCluster

To verify the connection to your cluster, use the kubectl get command to return a list of the cluster nodes.

    λ kubectl get nodes

If your AKS cluster uses RBAC, a ClusterRoleBinding must be created before you can correctly access the dashboard. By default, the Kubernetes dashboard is deployed with minimal read access and displays RBAC access errors. The Kubernetes dashboard does not currently support user-provided credentials to determine the level of access, rather it uses the roles granted to the service account. A cluster administrator can choose to grant additional access to the kubernetes-dashboard service account, however this can be a vector for privilege escalation. You can also integrate Azure Active Directory authentication to provide a more granular level of access.

To create a binding, use the kubectl create clusterrolebinding command as shown in the following example.

    λ kubectl create clusterrolebinding kubernetes-dashboard --clusterrole=cluster-admin --serviceaccount=kube-system:kubernetes-dashboard

    More info [here](https://docs.microsoft.com/en-us/azure/aks/kubernetes-dashboard).

To start the Kubernetes dashboard, use the az aks browse command. The following example opens the dashboard for the cluster named myAKSCluster in the resource group named myResourceGroup:

    λ az aks browse --resource-group myResourceGroup --name myAKSCluster

This command creates a proxy between your development system and the Kubernetes API, and opens a web browser to the Kubernetes dashboard. If a web browser doesn't open to the Kubernetes dashboard, copy and paste the URL address noted in the Azure CLI, typically http://127.0.0.1:8001.    

The Dashboard UI is not deployed by default. To deploy it, run the following command:

kubectl apply -f https://raw.githubusercontent.com/kubernetes/dashboard/master/aio/deploy/recommended/kubernetes-dashboard.yaml