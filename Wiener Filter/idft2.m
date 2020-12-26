function out = idft2(x)
        y = zeros(size(x));
        y1 = y;
        C = size(x,2); %number of columns
        for c = 1:C
            y(:,c) = idft(x(:,c));
        end
        R = size(x,1); %number of rows
        for r = 1:R
            y1(r,:) = idft(y(r,:).');
        end
        out = y1;
end