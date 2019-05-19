# Build docker image
docker build -t mywebapi .

# Run docker image locally
#docker run -p 8080:80 mywebapi

## Kubernetes

# Get cluster info
kubectl cluster-info

# Get nodes
kubectl get nodes

# Run
kubectl run mywebapi --image=mywebapi --port=80 --image-pull-policy=Never

# Get pods
kubectl get pods

# Create service
kubectl expose deployment/mywebapi --port=80 --type=LoadBalancer

# Get services
kubectl get svc

# Ping
curl "http://localhost/api/Health"

# Crate Horizontal Pod Autoscaler
kubectl autoscale deployment mywebapi --cpu-percent=50 --min=1 --max=10