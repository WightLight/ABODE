#!/bin/bash

git pull --rebase
git add -A
git commit -m "$1"
git push

