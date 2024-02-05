using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;
using System;

name: DevOps Lab Exercises
on:
  push:
branches:
-main
jobs:
build:
runs - on: ubuntu - latest
    steps:
-name: Checkout code
        uses: actions / checkout@v4
      - name: Use Node.js
        uses: actions/setup-node @v3
        with:
          node-version: '20.x'
      - run: npm ci
      - run: npm run build --if-present
      - run: npm test
