# Demo Project / Showcase Terraform GCP

1. create GCP Project
2. create artifact registry
3. create service account (with owner for now)
4. create service account key
5. build docker image and push it
   - `docker build -t europe-west6-docker.pkg.dev/cas-test-demo-run/demo-docker-repo/hello-world .`
   - `docker push europe-west6-docker.pkg.dev/cas-test-demo-run/demo-docker-repo/hello-world`
6. start cloud run manually
7. create google cloud storage bucket as terraform backend
8. use terraform to create cloud run & cloud function
