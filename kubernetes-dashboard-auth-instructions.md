# Instructions to access the Kubernetes Dashboard

Run the dashboard:

    λ kubectl proxy

By default the dashboard is secured, therefore  you would need to grab the Bearer token:

    λ bash auth.sh

Copy the token that got printed out via console.    

Kubectl will make Dashboard available at http://localhost:8001/api/v1/namespaces/kube-system/services/https:kubernetes-dashboard:/proxy/ and paste the token from the previous step.

More info abuot the dashboard [here](https://kubernetes.io/docs/tasks/access-application-cluster/web-ui-dashboard/).