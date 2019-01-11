#!/bin/sh
###############################################################
# Service > systemd > dotnet.service
# Sample Project > /root
# ip Change > 192.168.3."You linux ip"
# MariaDB > user(root)/password(test) > table(test.board)
###############################################################

gitPath="https://github.com/ljh5432/20190110_LJH.git"
rootDir="/root"
projectDir="/Project"
repository_Dir="/20190110_LJH"
publishDir="${projectDir}/bin/Debug/netcoreapp2.1/publish"
serviceDir="/publish"

cd ${rootDir}

#빌드 대상 프로젝트 경로 확인
if [ -d $rootDir$projectDir ]; then
  rm -Rf $rootDir$projectDir
fi

# 1. GitHub Repository Download
git clone $gitPath
mv ${rootDir}${repository_Dir}${projectDir} ${rootDir}
cd $rootDir$projectDir

# 2. Project Build
dotnet build

# 3. Service Shutdown
systemctl stop dotnet.service

# 4. Project Publish
dotnet publish

# 링크연결
ln -s $rootDir$publishDir $rootDir$serviceDir

# 5. Service Run
systemctl start dotnet.service

exit 0

