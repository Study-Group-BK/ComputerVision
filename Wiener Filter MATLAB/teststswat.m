% This program is written for simple 2 D FFT for image reconstruction without %using fft2 and ifft2 matlab inbuilt function
clc
close all
clear all
 
f =rgb2gray(imread('lenna.tif'));
f=double(f);
K=dft2(f);
KK=ifft2(K);
immse(KK,f)