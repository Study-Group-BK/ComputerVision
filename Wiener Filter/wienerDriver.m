%% Clear
clear all
close all
clc

%% Input and display the binary image
I0 = imread('lenna.tif');
row = size(I0,1);
column=size(I0,2);
I=rgb2gray(I0);
I=double(I);

%% Blur the image, corrupt the image using WGN and display it
% h is the blurring filter, and sigma is the noise std
h = ones(4,4)/16;

sigma = 20;
Xf = dft2(I);
h=[h zeros(size(h,2),column-size(h,2));zeros(row-size(h,1),column)];
Hf = dft2(h);

y = real(idft2(Hf.*Xf))+sigma*randn(row,column); % circular convolution %randn is normally distributed
%y = filter2(h,x)+sigma*randn(N,N);	  % linear convolution

%% Restoration using generalized Wiener filtering
gamma = 1;
alpha = 1;
ewx = WienerFilter_dft(y,h,sigma,gamma,alpha);
PSNR = abs([psnr(I,I) psnr(y,I) psnr(ewx,I)])
MSE = [immse(I,I) immse(y,I) immse(ewx,I)]
subplot(221)
imshow(I0)
subplot(222)
imshow(I,gray(256))
subplot(223)
imshow(y,gray(256))
subplot(224)
imshow(ewx,gray(256))
return
