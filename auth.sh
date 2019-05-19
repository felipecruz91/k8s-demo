#!/bin/bash
TOKEN=$(kubectl -n kube-system describe secret default| awk '$1=="token:"{print $2}')

echo ${TOKEN}

kubectl config set-credentials kubernetes-admin --token="${TOKEN}"