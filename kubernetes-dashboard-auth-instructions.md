# Instructions to access the Kubernetes Dashboard

Run the dashboard:

    λ kubectl proxy

By default the dashboard is secured, therefore  you would need to grab the Bearer token:

    λ kubectl -n kube-system describe secrets replicaset-controller-token-fx5lv

Finally access the dashboard through the following URL:

http://localhost:8001/api/v1/namespaces/kube-system/services/https:kubernetes-dashboard:/proxy/