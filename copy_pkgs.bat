@echo off

REM change pkg_dir to conda installation pkgs location
set pkg_dir=%localappdata%\miniforge3\pkgs

REM this will be where the packages are sent
set dest_dir="bin\Debug\netcoreapp3.1\pkgs"

echo F|xcopy "%pkg_dir%\abseil-cpp-20211102.0-h0e60522_0.tar.bz2" "%dest_dir%\abseil-cpp-20211102.0-h0e60522_0.tar.bz2" /v /Y 
echo F|xcopy "%pkg_dir%\activitysim-1.0.4-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\activitysim-1.0.4-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\arrow-cpp-7.0.0-py39h735a502_1_cpu.tar.bz2" "%dest_dir%\arrow-cpp-7.0.0-py39h735a502_1_cpu.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\aws-c-cal-0.5.11-he19cf47_0.tar.bz2" "%dest_dir%\aws-c-cal-0.5.11-he19cf47_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\aws-c-common-0.6.2-h8ffe710_0.tar.bz2" "%dest_dir%\aws-c-common-0.6.2-h8ffe710_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\aws-c-event-stream-0.2.7-h70e1b0c_13.tar.bz2" "%dest_dir%\aws-c-event-stream-0.2.7-h70e1b0c_13.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\aws-c-io-0.10.5-h2fe331c_0.tar.bz2" "%dest_dir%\aws-c-io-0.10.5-h2fe331c_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\aws-checksums-0.1.11-h1e232aa_7.tar.bz2" "%dest_dir%\aws-checksums-0.1.11-h1e232aa_7.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\aws-sdk-cpp-1.8.186-hb0612c5_3.tar.bz2" "%dest_dir%\aws-sdk-cpp-1.8.186-hb0612c5_3.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\blosc-1.21.0-h0e60522_0.tar.bz2" "%dest_dir%\blosc-1.21.0-h0e60522_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\brotlipy-0.7.0-py39hb82d6ee_1003.tar.bz2" "%dest_dir%\brotlipy-0.7.0-py39hb82d6ee_1003.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\bzip2-1.0.8-h8ffe710_4.tar.bz2" "%dest_dir%\bzip2-1.0.8-h8ffe710_4.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\c-ares-1.18.1-h8ffe710_0.tar.bz2" "%dest_dir%\c-ares-1.18.1-h8ffe710_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\ca-certificates-2021.10.8-h5b45459_0.tar.bz2" "%dest_dir%\ca-certificates-2021.10.8-h5b45459_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\certifi-2021.10.8-py39hcbf5309_1.tar.bz2" "%dest_dir%\certifi-2021.10.8-py39hcbf5309_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\cffi-1.15.0-py39h0878f49_0.tar.bz2" "%dest_dir%\cffi-1.15.0-py39h0878f49_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\charset-normalizer-2.0.12-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\charset-normalizer-2.0.12-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\click-8.0.4-py39hcbf5309_0.tar.bz2" "%dest_dir%\click-8.0.4-py39hcbf5309_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\colorama-0.4.4-pyh9f0ad1d_0.tar.bz2" "%dest_dir%\colorama-0.4.4-pyh9f0ad1d_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\cryptography-36.0.1-py39h7bc7c5c_0.tar.bz2" "%dest_dir%\cryptography-36.0.1-py39h7bc7c5c_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\cytoolz-0.11.2-py39hb82d6ee_1.tar.bz2" "%dest_dir%\cytoolz-0.11.2-py39hb82d6ee_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\flask-2.0.3-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\flask-2.0.3-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\gflags-2.2.2-ha925a31_1004.tar.bz2" "%dest_dir%\gflags-2.2.2-ha925a31_1004.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\glog-0.5.0-h4797de2_0.tar.bz2" "%dest_dir%\glog-0.5.0-h4797de2_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\grpc-cpp-1.43.2-h7b4b439_2.tar.bz2" "%dest_dir%\grpc-cpp-1.43.2-h7b4b439_2.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\hdf5-1.12.1-nompi_h2a0e4a3_104.tar.bz2" "%dest_dir%\hdf5-1.12.1-nompi_h2a0e4a3_104.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\idna-3.3-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\idna-3.3-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\intel-openmp-2022.0.0-h57928b3_3663.tar.bz2" "%dest_dir%\intel-openmp-2022.0.0-h57928b3_3663.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\itsdangerous-2.1.1-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\itsdangerous-2.1.1-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\jinja2-3.0.3-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\jinja2-3.0.3-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\krb5-1.19.2-h1176d77_4.tar.bz2" "%dest_dir%\krb5-1.19.2-h1176d77_4.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libblas-3.9.0-13_win64_mkl.tar.bz2" "%dest_dir%\libblas-3.9.0-13_win64_mkl.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libbrotlicommon-1.0.9-h8ffe710_6.tar.bz2" "%dest_dir%\libbrotlicommon-1.0.9-h8ffe710_6.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libbrotlidec-1.0.9-h8ffe710_6.tar.bz2" "%dest_dir%\libbrotlidec-1.0.9-h8ffe710_6.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libbrotlienc-1.0.9-h8ffe710_6.tar.bz2" "%dest_dir%\libbrotlienc-1.0.9-h8ffe710_6.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libcblas-3.9.0-13_win64_mkl.tar.bz2" "%dest_dir%\libcblas-3.9.0-13_win64_mkl.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libcurl-7.82.0-h789b8ee_0.tar.bz2" "%dest_dir%\libcurl-7.82.0-h789b8ee_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libffi-3.4.2-h8ffe710_5.tar.bz2" "%dest_dir%\libffi-3.4.2-h8ffe710_5.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\liblapack-3.9.0-13_win64_mkl.tar.bz2" "%dest_dir%\liblapack-3.9.0-13_win64_mkl.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libprotobuf-3.19.4-h7755175_0.tar.bz2" "%dest_dir%\libprotobuf-3.19.4-h7755175_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libssh2-1.10.0-h680486a_2.tar.bz2" "%dest_dir%\libssh2-1.10.0-h680486a_2.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libthrift-0.15.0-h636ae23_1.tar.bz2" "%dest_dir%\libthrift-0.15.0-h636ae23_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libutf8proc-2.7.0-hcb41399_0.tar.bz2" "%dest_dir%\libutf8proc-2.7.0-hcb41399_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\libzlib-1.2.11-h8ffe710_1013.tar.bz2" "%dest_dir%\libzlib-1.2.11-h8ffe710_1013.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\llvmlite-0.38.0-py39ha0cd8c8_0.tar.bz2" "%dest_dir%\llvmlite-0.38.0-py39ha0cd8c8_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\lz4-c-1.9.3-h8ffe710_1.tar.bz2" "%dest_dir%\lz4-c-1.9.3-h8ffe710_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\markupsafe-2.1.0-py39hb82d6ee_1.tar.bz2" "%dest_dir%\markupsafe-2.1.0-py39hb82d6ee_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\mkl-2022.0.0-h0e2418a_796.tar.bz2" "%dest_dir%\mkl-2022.0.0-h0e2418a_796.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\numba-0.55.1-py39hb8cd55e_0.tar.bz2" "%dest_dir%\numba-0.55.1-py39hb8cd55e_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\numexpr-2.7.3-py39h2e25243_2.tar.bz2" "%dest_dir%\numexpr-2.7.3-py39h2e25243_2.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\numpy-1.21.5-py39h6331f09_0.tar.bz2" "%dest_dir%\numpy-1.21.5-py39h6331f09_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\openmatrix-0.3.5.0-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\openmatrix-0.3.5.0-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\openssl-1.1.1l-h8ffe710_0.tar.bz2" "%dest_dir%\openssl-1.1.1l-h8ffe710_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\orca-1.6-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\orca-1.6-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\packaging-21.3-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\packaging-21.3-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pandas-1.4.1-py39h2e25243_0.tar.bz2" "%dest_dir%\pandas-1.4.1-py39h2e25243_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\parquet-cpp-1.5.1-2.tar.bz2" "%dest_dir%\parquet-cpp-1.5.1-2.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pip-22.0.4-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\pip-22.0.4-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\psutil-5.9.0-py39hb82d6ee_0.tar.bz2" "%dest_dir%\psutil-5.9.0-py39hb82d6ee_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pyarrow-7.0.0-py39ha05331a_1_cpu.tar.bz2" "%dest_dir%\pyarrow-7.0.0-py39ha05331a_1_cpu.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pycparser-2.21-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\pycparser-2.21-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pygments-2.11.2-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\pygments-2.11.2-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pyopenssl-22.0.0-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\pyopenssl-22.0.0-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pyparsing-3.0.7-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\pyparsing-3.0.7-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pysocks-1.7.1-py39hcbf5309_4.tar.bz2" "%dest_dir%\pysocks-1.7.1-py39hcbf5309_4.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pytables-3.7.0-py39hbcfe41f_0.tar.bz2" "%dest_dir%\pytables-3.7.0-py39hbcfe41f_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\python-3.9.10-h9a09f29_2_cpython.tar.bz2" "%dest_dir%\python-3.9.10-h9a09f29_2_cpython.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\python-dateutil-2.8.2-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\python-dateutil-2.8.2-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\python_abi-3.9-2_cp39.tar.bz2" "%dest_dir%\python_abi-3.9-2_cp39.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pytz-2021.3-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\pytz-2021.3-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\pyyaml-6.0-py39hb82d6ee_3.tar.bz2" "%dest_dir%\pyyaml-6.0-py39hb82d6ee_3.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\re2-2022.02.01-h0e60522_0.tar.bz2" "%dest_dir%\re2-2022.02.01-h0e60522_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\requests-2.27.1-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\requests-2.27.1-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\setuptools-60.9.3-py39hcbf5309_0.tar.bz2" "%dest_dir%\setuptools-60.9.3-py39hcbf5309_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\six-1.16.0-pyh6c4a22f_0.tar.bz2" "%dest_dir%\six-1.16.0-pyh6c4a22f_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\snappy-1.1.8-ha925a31_3.tar.bz2" "%dest_dir%\snappy-1.1.8-ha925a31_3.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\sqlite-3.37.0-h8ffe710_0.tar.bz2" "%dest_dir%\sqlite-3.37.0-h8ffe710_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\tbb-2021.5.0-h2d74725_0.tar.bz2" "%dest_dir%\tbb-2021.5.0-h2d74725_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\tk-8.6.12-h8ffe710_0.tar.bz2" "%dest_dir%\tk-8.6.12-h8ffe710_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\toolz-0.11.2-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\toolz-0.11.2-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\tzdata-2021e-he74cb21_0.tar.bz2" "%dest_dir%\tzdata-2021e-he74cb21_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\ucrt-10.0.20348.0-h57928b3_0.tar.bz2" "%dest_dir%\ucrt-10.0.20348.0-h57928b3_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\urllib3-1.26.8-pyhd8ed1ab_1.tar.bz2" "%dest_dir%\urllib3-1.26.8-pyhd8ed1ab_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\vc-14.2-hb210afc_6.tar.bz2" "%dest_dir%\vc-14.2-hb210afc_6.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\vs2015_runtime-14.29.30037-h902a5da_6.tar.bz2" "%dest_dir%\vs2015_runtime-14.29.30037-h902a5da_6.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\werkzeug-2.0.3-pyhd8ed1ab_1.tar.bz2" "%dest_dir%\werkzeug-2.0.3-pyhd8ed1ab_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\wheel-0.37.1-pyhd8ed1ab_0.tar.bz2" "%dest_dir%\wheel-0.37.1-pyhd8ed1ab_0.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\win_inet_pton-1.1.0-py39hcbf5309_3.tar.bz2" "%dest_dir%\win_inet_pton-1.1.0-py39hcbf5309_3.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\xz-5.2.5-h62dcd97_1.tar.bz2" "%dest_dir%\xz-5.2.5-h62dcd97_1.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\yaml-0.2.5-h8ffe710_2.tar.bz2" "%dest_dir%\yaml-0.2.5-h8ffe710_2.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\zlib-1.2.11-h8ffe710_1013.tar.bz2" "%dest_dir%\zlib-1.2.11-h8ffe710_1013.tar.bz2" /v /Y
echo F|xcopy "%pkg_dir%\zstd-1.5.2-h6255e5f_0.tar.bz2" "%dest_dir%\zstd-1.5.2-h6255e5f_0.tar.bz2" /v /Y

set pkg_dir=
set dest_dir=

pause