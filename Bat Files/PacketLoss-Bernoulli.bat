docker run -it --rm -v /var/run/docker.sock:/var/run/docker.sock gaiaadm/pumba netem --interface eth0 --duration 1m loss --percent 3 HostA

